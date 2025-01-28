namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Product user price.
    /// </summary>
    public interface IProductBundledUserPriceModel : IWebApiModel
    {
        /// <summary>
        /// The price for this user price.
        /// </summary>
        decimal? Price { get; set; }

        /// <summary>
        /// The Id of the user group this user price is associated with.
        /// </summary>
        int UserGroupId { get; set; }
    }
}