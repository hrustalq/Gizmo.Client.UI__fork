﻿using Gizmo.UI.View.States;
using Microsoft.Extensions.DependencyInjection;

namespace Gizmo.Client.UI.View.States
{
    /// <summary>
    /// Sign in configuration view state.
    /// </summary>
    [Register()]
    public sealed class UserLoginConfigurationViewState : ViewStateBase
    {
        private bool _isEnabled;

        public bool IsEnabled
        {
            get { return _isEnabled; }
            internal set { _isEnabled = value; }
        }
    }
}
