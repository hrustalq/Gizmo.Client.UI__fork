﻿using Gizmo.UI.View.States;
using Microsoft.Extensions.DependencyInjection;

namespace Gizmo.Client.UI.View.States
{
    [Register()]
    public sealed class BusinessLogoViewState : ViewStateBase
    {
        #region FIELDS
        private string? _businessLogo;
        #endregion

        #region PROPERTIES

        public string? BusinessLogo
        {
            get { return _businessLogo; }
            internal set { _businessLogo = value; }
        } 
       
        #endregion
    }
}
