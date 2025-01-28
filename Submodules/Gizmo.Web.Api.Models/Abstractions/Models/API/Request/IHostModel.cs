namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Host.
    /// </summary>
    public interface IHostModel : IWebApiModel
    {
        /// <summary>
        /// The host computer object attached to this host if the host is a computer, otherwise it will be null.
        /// </summary>
        HostModelComputer? HostComputer { get; set; }

        /// <summary>
        /// The host endpoint object attached to this host if the host is an endpoint, otherwise it will be null.
        /// </summary>
        HostModelEndpoint? HostEndpoint { get; set; }

        /// <summary>
        /// The Id of the host group this host belongs to.
        /// </summary>
        int? HostGroupId { get; set; }

        /// <summary>
        /// The Id of the host icon this host is associated with.
        /// </summary>
        int? IconId { get; set; }

        /// <summary>
        /// Whether the host is deleted.
        /// </summary>
        bool IsDeleted { get; set; }

        /// <summary>
        /// Host is locked.
        /// </summary>
        bool IsLocked { get; set; }

        /// <summary>
        /// Host is out of order.
        /// </summary>
        bool IsOutOfOrder { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The number of the host.
        /// </summary>
        int Number { get; set; }
    }
}