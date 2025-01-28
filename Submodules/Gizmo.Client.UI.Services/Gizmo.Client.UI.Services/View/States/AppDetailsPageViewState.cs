﻿using Gizmo.UI.View.States;
using Microsoft.Extensions.DependencyInjection;

namespace Gizmo.Client.UI.View.States
{
    [Register()]
    public sealed class AppDetailsPageViewState : ViewStateBase
    {
        #region PROPERTIES

        public AppViewState? Application { get; internal set; }

        public IEnumerable<AppExeViewState> Executables { get; internal set; } = Enumerable.Empty<AppExeViewState>();
        
        public bool DisableAppDetails { get; internal set; }

        #endregion
    }
}
