namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Host group.
    /// </summary>
    public interface IHostGroupModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the guest group this host group uses by default.
        /// </summary>
        int? ApplicationGroupId { get; set; }

        /// <summary>
        /// The Id of the application profile this host group is associated with.
        /// </summary>
        int? DefaultGuestGroupId { get; set; }

        /// <summary>
        /// The name of the host group.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The Id of the security profile this host group is associated with.
        /// </summary>
        int? SecurityProfileId { get; set; }

        /// <summary>
        /// The name of the skin this host group uses by default.
        /// </summary>
        string? SkinName { get; set; }
    }
}