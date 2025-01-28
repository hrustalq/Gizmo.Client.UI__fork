namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User group disallowed host group.
    /// </summary>
    public interface IUserGroupDisallowedHostGroupModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the host group.
        /// </summary>
        int HostGroupId { get; set; }

        /// <summary>
        /// Whether this host group is disallowed for this user group.
        /// </summary>
        bool IsDisallowed { get; set; }
    }
}