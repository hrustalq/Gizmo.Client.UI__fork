namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User product group model.
    /// </summary>
    public interface IUserProductGroupModel : IWebApiModel
    {
        /// <summary>
        /// The name of the product group.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The sort option of the product group.
        /// </summary>
        ProductSortOptionType SortOption { get; set; }

        /// <summary>
        /// The display order of the product group.
        /// </summary>
        int DisplayOrder { get; set; }
    }
}
