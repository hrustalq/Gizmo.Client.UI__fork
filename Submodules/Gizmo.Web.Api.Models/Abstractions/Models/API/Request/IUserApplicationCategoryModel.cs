namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User application group model.
    /// </summary>
    public interface IUserApplicationCategoryModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the parent application category.
        /// </summary>
        int? ParentId { get; set; }

        /// <summary>
        /// The name of the application category.
        /// </summary>
        string Name { get; set; }
    }
}
