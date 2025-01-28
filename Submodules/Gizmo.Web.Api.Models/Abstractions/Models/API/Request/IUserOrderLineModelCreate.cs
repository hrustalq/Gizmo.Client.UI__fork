namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User order line model.
    /// </summary>
    public interface IUserOrderLineModelCreate : IWebApiModel
    {
        /// <summary>
        /// The Id of the product this order line is associated with.
        /// </summary>
        int ProductId { get; set; }

        /// <summary>
        /// The quantity of the product.
        /// </summary>
        int Quantity { get; set; }

        /// <summary>
        /// The pay type of the order line.
        /// </summary>
        OrderLinePayType PayType { get; set; }

        /*/// <summary>
        /// The total amount of the order line.
        /// </summary>
        decimal Total { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        int PointsTotal { get; set; }*/
    }
}
