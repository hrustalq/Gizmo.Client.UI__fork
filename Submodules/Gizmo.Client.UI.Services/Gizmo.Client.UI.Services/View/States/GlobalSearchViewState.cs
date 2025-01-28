﻿using Gizmo.UI.View.States;
using Microsoft.Extensions.DependencyInjection;

namespace Gizmo.Client.UI.View.States
{
    [Register()]
    public sealed class GlobalSearchViewState : ViewStateBase
    {
        #region PROPERTIES

        public bool OpenDropDown { get; internal set; }

        public bool IsLoading { get; internal set; }

        public string SearchPattern { get; internal set; } = null!;

        public IEnumerable<GlobalSearchResultViewState> ExecutableResults { get; internal set; } = Enumerable.Empty<GlobalSearchResultViewState>();

        public IEnumerable<GlobalSearchResultViewState> ProductResults { get; internal set; } = Enumerable.Empty<GlobalSearchResultViewState>();

        public string EmptyResultTitle { get; internal set; } = null!;

        public string EmptyResultMessage { get; internal set; } = null!;

        #endregion
    }
}
