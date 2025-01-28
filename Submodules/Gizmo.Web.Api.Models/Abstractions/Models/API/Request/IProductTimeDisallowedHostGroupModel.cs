namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Time product disallowed host group.
    /// </summary>
    public interface IProductTimeDisallowedHostGroupModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the host group.
        /// </summary>
        int HostGroupId { get; set; }

        /// <summary>
        /// Whether this host group is disallowed for this time product.
        /// </summary>
        bool IsDisallowed { get; set; }
    }
}