using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order line.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class OrderLineModel : IOrderLineModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The type of the order line.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public LineType LineType { get; set; }

        /// <summary>
        /// The pay type of the order line.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(2)]
        public OrderLinePayType PayType { get; set; }

        /// <summary>
        /// The name of the item in the order line.
        /// </summary>
        [MessagePack.Key(3)]
        public string? ProductName { get; set; }

        /// <summary>
        /// The quantity of items in the order line.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The price for one unit in this order line.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The tax rate of the order line.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal TaxRate { get; set; }

        /// <summary>
        /// The total amount excluding tax.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal PreTaxTotal { get; set; }

        /// <summary>
        /// The total tax of the order line.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the order line.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal Total { get; set; }

        /// <summary>
        /// The cost in points for one unit in this order line.
        /// </summary>
        [MessagePack.Key(10)]
        public int UnitPointsPrice { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        [MessagePack.Key(11)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The amount of points the user earns from one unit in this order line.
        /// </summary>
        [MessagePack.Key(12)]
        public int? UnitPointsAward { get; set; }

        /// <summary>
        /// The total amount of points the user earns from this invoice line.
        /// </summary>
        [MessagePack.Key(13)]
        public int? PointsAwardTotal { get; set; }

        /// <summary>
        /// The cost of one unit in this order line.
        /// </summary>
        [MessagePack.Key(14)]
        public decimal? UnitCost { get; set; }

        /// <summary>
        /// The total cost of this order line.
        /// </summary>
        [MessagePack.Key(15)]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Whether all the items of the order line have been delivered.
        /// </summary>
        [MessagePack.Key(16)]
        public bool IsDelivered { get; set; }

        /// <summary>
        /// The quantity of items that have been delivered.
        /// </summary>
        [MessagePack.Key(17)]
        public decimal DeliveredQuantity { get; set; }

        /// <summary>
        /// The Id of the bundle line this line belongs to if the line refers to a bundled product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(18)]
        public int? BundleLineId { get; set; }

        /// <summary>
        /// The product object attached to this order line if the order line refers to a product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(19)]
        public ProductLineModel? Product { get; set; }

        /// <summary>
        /// The time product object attached to this order line if the order line refers to a time product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(20)]
        public ProductLineModel? TimeProduct { get; set; }

        #endregion
    }
}