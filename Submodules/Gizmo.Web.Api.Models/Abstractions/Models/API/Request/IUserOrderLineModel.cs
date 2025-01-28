namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User order line model.
    /// </summary>
    public interface IUserOrderLineModel : IWebApiModel
    {
        /// <summary>
        /// The type of the order line.
        /// </summary>
        LineType LineType { get; set; }

        /// <summary>
        /// The pay type of the order line.
        /// </summary>
        OrderLinePayType PayType { get; set; }

        /// <summary>
        /// The name of the item in the order line.
        /// </summary>
        string? ProductName { get; set; }

        /// <summary>
        /// The quantity of the product.
        /// </summary>
        int Quantity { get; set; }

        /// <summary>
        /// The total amount of the order line.
        /// </summary>
        decimal Total { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        int PointsTotal { get; set; }

        /// <summary>
        /// The Id of the product this order line is associated with.
        /// </summary>
        int? ProductId { get; set; }
    }
}
