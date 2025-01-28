using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User order line model.
    /// </summary>
    [MessagePackObject]
    public sealed class UserOrderLineModelCreate : IUserOrderLineModelCreate
    {
        #region PROPERTIES

        /// <summary>
        /// The guid of the order line.
        /// </summary>
        [Key(0)]
        public Guid Guid { get; init; }

        /// <summary>
        /// The Id of the product this order line is associated with.
        /// </summary>
        [Key(1)]
        public int ProductId { get; set; }

        /// <summary>
        /// The quantity of the product.
        /// </summary>
        [Key(2)]
        public int Quantity { get; set; }

        /// <summary>
        /// The pay type of the order line.
        /// </summary>
        [System.ComponentModel.DataAnnotations.EnumValueValidation]
        [Key(3)]
        public OrderLinePayType PayType { get; set; }

        /// <summary>
        /// The total amount of the order line.
        /// </summary>
        [Key(4)]
        public decimal Total { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        [Key(5)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The total amount of points the user earns from this order line.
        /// </summary>
        [Key(6)]
        public int PointsAwardTotal { get; set; }

        #endregion
    }
}
