namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Popular product.
    /// </summary>
    public interface IPopularProductModel : IWebApiModel
    {
        /// <summary>
        /// Total purchases.
        /// </summary>
        int TotalPurchases { get; init; }
    }
}
