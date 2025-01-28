﻿using Gizmo.UI.View.States;
using Microsoft.Extensions.DependencyInjection;

namespace Gizmo.Client.UI.View.States
{
    [Register(Scope = RegisterScope.Transient)]
    public sealed class UserOrderLineViewState : ViewStateBase
    {
        #region PROPERTIES

        public int Id { get; internal set; }

        public LineType LineType { get; internal set; }

        public OrderLinePayType PayType { get; internal set; }

        public string ProductName { get; internal set; } = string.Empty;

        public int Quantity { get; internal set; }

        public decimal TotalPrice { get; internal set; }

        public int TotalPointsPrice { get; internal set; }

        public int? ProductId { get; internal set; }

        #endregion
    }
}
