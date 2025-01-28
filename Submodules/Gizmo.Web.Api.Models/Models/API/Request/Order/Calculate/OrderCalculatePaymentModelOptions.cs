using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculate order options.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class OrderCalculatePaymentModelOptions : IOrderCalculateOptionsModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the payment method that is preferred.
        /// </summary>
        [Key(0)]
        public int? PreferredPaymentMethodId { get; set; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [Key(1)]
        public IEnumerable<OrderLineModelOptions> OrderLines { get; set; } = Enumerable.Empty<OrderLineModelOptions>();

        #endregion
    }
}