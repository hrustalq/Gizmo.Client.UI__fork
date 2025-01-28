namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application category.
    /// </summary>
    public interface IApplicationCategoryModel : IWebApiModel
    {
        /// <summary>
        /// The name of the application category.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The Id of the parent category if the category is a subcategory, otherwise it will be null.
        /// </summary>
        int? ParentId { get; set; }
    }
}