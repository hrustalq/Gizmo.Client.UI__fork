namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Product user price.
    /// </summary>
    public interface IProductUserPriceModel : IProductBundledUserPriceModel
    {

        /// <summary>
        /// The price in points for this user price.
        /// </summary>
        int? PointsPrice { get; set; }

        /// <summary>
        /// The purchase options for this user price.
        /// </summary>
        PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// Whether the user prices is enabled.
        /// </summary>
        bool IsEnabled { get; set; }
    }
}