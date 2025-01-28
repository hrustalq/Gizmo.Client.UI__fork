﻿using Gizmo.Client.UI.View.States;
using Gizmo.UI.View.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Gizmo.Client.UI.View.Services
{
    [Register()]
    [Route(ClientRoutes.LoginRoute)]
    public sealed class LoginRotatorViewService : ViewStateServiceBase<LoginRotatorViewState>
    {
        #region CONSTRUCTOR
        public LoginRotatorViewService(LoginRotatorViewState viewState,
            ILogger<LoginRotatorViewService> logger,
            IServiceProvider serviceProvider,
            IOptions<LoginRotatorOptions> loginRotatorOptions) : base(viewState, logger, serviceProvider)
        {
            _loginRotatorOptions = loginRotatorOptions;
        }
        #endregion

        #region STATIC FIELDS

        private static readonly string[] IMAGE_EXTENSIONS = new string[]
        {
            ".JPG",
            ".PNG",
            ".BMP"
        };

        private static readonly string[] VIDEO_EXTENSIONS = new string[]
        {
            ".M4V",
            ".MP4",
            ".WMV",
            ".AVI",
        };

        private static readonly string[] ALL_EXTENSIONS = IMAGE_EXTENSIONS.Union(VIDEO_EXTENSIONS).ToArray();

        #endregion

        #region FIELDS
        private readonly IOptions<LoginRotatorOptions> _loginRotatorOptions;
        private Timer? _rotatateTimer;
        private List<LoginRotatorItemViewState> _items = new();
        private int _index = 0;
        private readonly object _itemsLock = new object();
        #endregion

        #region FUNCTIONS

        private int GetRotateMills()
        {
            if (_loginRotatorOptions.Value.RotateEvery <= 0)
                return 6000; //just in case check that correct value is set and provide default value if not

            return (int)TimeSpan.FromSeconds(_loginRotatorOptions.Value.RotateEvery).TotalMilliseconds;
        }

        #endregion

        private void OnTimerCallback(object? state)
        {
            if (Monitor.TryEnter(_itemsLock))
            {
                try
                {
                    _index += 1;

                    if (_index == _items.Count)
                        _index = 0;

                    ViewState.CurrentItem = _items[_index];
                }
                catch (Exception ex)
                {
                    Logger.LogError(ex, "Failed to adjust rotator item based on index within timer callback.");
                }
                finally
                {
                    Monitor.Exit(_itemsLock);
                }
            }

            if (ViewState.CurrentItem?.IsVideo == true)
            {
                _rotatateTimer?.Dispose();
            }

            DebounceViewStateChanged();
        }

        public Task PlayNext()
        {
            if (Monitor.TryEnter(_itemsLock))
            {
                try
                {
                    _index += 1;

                    if (_index == _items.Count)
                        _index = 0;
                }
                catch (Exception ex)
                {
                    Logger.LogError(ex, "Failed to play next item based on index.");
                }
                finally
                {
                    Monitor.Exit(_itemsLock);
                }
            }

            ViewState.CurrentItem = _items[_index];

            if (ViewState.CurrentItem?.IsVideo == false)
            {
                _rotatateTimer?.Dispose();
                _rotatateTimer = new Timer(OnTimerCallback, null, GetRotateMills(), GetRotateMills());
            }

            DebounceViewStateChanged();

            return Task.CompletedTask;
        }

        #region OVERRIDES

        protected override Task OnNavigatedIn(NavigationParameters navigationParameters, CancellationToken cToken = default)
        {
            if (_loginRotatorOptions.Value.IsEnabled)
            {
                //get current rotator folder
                var rotateFolder = _loginRotatorOptions.Value.Path;

                if (!string.IsNullOrEmpty(rotateFolder))
                {
                    if (Monitor.TryEnter(_loginRotatorOptions, Timeout.Infinite))
                    {
                        try
                        {
                            _items.Clear();
                        }
                        catch
                        {
                            throw;
                        }
                        finally
                        {
                            Monitor.Exit(_loginRotatorOptions);
                        }
                    }

                    IEnumerable<string> GetRelativePaths(string root)
                    {
                        if (!Directory.Exists(rotateFolder))
                        {
                            Logger.LogError("Login rotator directory {directory} not found.", rotateFolder);
                            yield break;
                        }

                        int rootLength = root.Length + (root[^1] == '\\' ? 0 : 1);

                        foreach (string path in Directory.GetFiles(root, "*.*", SearchOption.AllDirectories)
                                               .Where(FILE => ALL_EXTENSIONS.Any(EXTESNSION => FILE.EndsWith(EXTESNSION, StringComparison.InvariantCultureIgnoreCase))))
                        {
                            yield return path.Remove(0, rootLength);
                        }
                    }

                    try
                    {
                        var mediaFilesRelativePaths = GetRelativePaths(rotateFolder);
                        var random = new Random();
                        _items = mediaFilesRelativePaths.Select(FILE => new LoginRotatorItemViewState()
                        {
                            MediaPath = Path.Combine("https://", "rotator", FILE).Replace('\\', '/'),
                            IsVideo = VIDEO_EXTENSIONS.Any(EXTENSION => FILE.EndsWith(EXTENSION, StringComparison.InvariantCultureIgnoreCase))
                        }).ToList();

                        _items.Shuffle();
                    }
                    catch (Exception ex)
                    {
                        Logger.LogError(ex, "Failed to initialize login rotator.");
                    }

                    if (_items.Any())
                    {
                        ViewState.IsEnabled = _loginRotatorOptions.Value.IsEnabled;
                        ViewState.CurrentItem = _items[_index];

                        if (ViewState.CurrentItem?.IsVideo == false)
                        {
                            _rotatateTimer?.Dispose();
                            _rotatateTimer = new Timer(OnTimerCallback, null, GetRotateMills(), GetRotateMills());
                        }
                    }
                }
            }

            return Task.CompletedTask;
        }

        protected override void OnDisposing(bool isDisposing)
        {
            _rotatateTimer?.Dispose();
            base.OnDisposing(isDisposing);
        }

        #endregion
    }

    static class ShuffleListExtension
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
