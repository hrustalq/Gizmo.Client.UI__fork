using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User order line model.
    /// </summary>
    [MessagePackObject]
    public sealed class UserOrderLineModel : IUserOrderLineModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The type of the order line.
        /// </summary>
        [Key(1)]
        public LineType LineType { get; set; }

        /// <summary>
        /// The pay type of the order line.
        /// </summary>
        [System.ComponentModel.DataAnnotations.EnumValueValidation]
        [Key(2)]
        public OrderLinePayType PayType { get; set; }

        /// <summary>
        /// The name of the item in the order line.
        /// </summary>
        [Key(3)]
        public string? ProductName { get; set; }

        /// <summary>
        /// The quantity of the product.
        /// </summary>
        [Key(4)]
        public int Quantity { get; set; }

        /// <summary>
        /// The total amount of the order line.
        /// </summary>
        [Key(5)]
        public decimal Total { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        [Key(6)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The Id of the product this order line is associated with.
        /// </summary>
        [Key(7)]
        public int? ProductId { get; set; }

        #endregion
    }
}
