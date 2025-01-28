using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculated order.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class OrderCalculatedModel : IOrderCalculatedModel
    {
        #region PROPERTIES

        /// <summary>
        /// The subtotal of the order line.
        /// </summary>
        [Key(0)]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// The total tax of the order line.
        /// </summary>
        [Key(1)]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the order line.
        /// </summary>
        [Key(2)]
        public decimal Total { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        [Key(3)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [Key(4)]
        public IEnumerable<OrderLineModel> OrderLines { get; set; } = Enumerable.Empty<OrderLineModel>();

        #endregion
    }
}