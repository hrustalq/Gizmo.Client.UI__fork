namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Product disallowed user group.
    /// </summary>
    public interface IProductDisallowedUserGroupModel : IWebApiModel
    {
        /// <summary>
        /// Whether this user group is disallowed for this product.
        /// </summary>
        bool IsDisallowed { get; set; }

        /// <summary>
        /// The Id of the user group.
        /// </summary>
        int UserGroupId { get; set; }
    }
}