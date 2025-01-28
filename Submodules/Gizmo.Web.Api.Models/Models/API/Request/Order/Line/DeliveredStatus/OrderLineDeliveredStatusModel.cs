using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order line delivered status.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class OrderLineDeliveredStatusModel
    {
        #region PROPERTIES

        /// <summary>
        /// The quantity of items in the order line.
        /// </summary>
        [Key(0)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The quantity of delivered items.
        /// </summary>
        [Key(1)]
        public decimal DeliveredQuantity { get; set; }

        /// <summary>
        /// Whether all items have been delivered.
        /// </summary>
        [Key(2)]
        public bool IsDelivered { get; set; }

        /// <summary>
        /// The date that all items were delivered.
        /// </summary>
        [Key(3)]
        public DateTime? DeliveredTime { get; set; }

        #endregion
    }
}