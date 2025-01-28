namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Bundled product.
    /// </summary>
    public interface IProductBundledModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the product.
        /// </summary>
        int ProductId { get; set; }

        /// <summary>
        /// The quantity of the product within the bundle.
        /// </summary>
        decimal Quantity { get; set; }

        /// <summary>
        /// The unit price of the product within the bundle.
        /// </summary>
        decimal UnitPrice { get; set; }
    }
}