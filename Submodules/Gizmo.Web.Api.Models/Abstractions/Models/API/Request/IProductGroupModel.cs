namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Product group.
    /// </summary>
    public interface IProductGroupModel : IWebApiModel
    {
        /// <summary>
        /// The display order of the product group.
        /// </summary>
        int DisplayOrder { get; set; }

        /// <summary>
        /// The name of the product group.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The sort option of the product group.
        /// </summary>
        ProductSortOptionType SortOption { get; set; }
    }
}