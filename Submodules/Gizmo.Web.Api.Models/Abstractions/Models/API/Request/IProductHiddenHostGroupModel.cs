namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Product hidden host group.
    /// </summary>
    public interface IProductHiddenHostGroupModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the host group.
        /// </summary>
        int HostGroupId { get; set; }

        /// <summary>
        /// Whether this product is hidden in this host group.
        /// </summary>
        bool IsHidden { get; set; }
    }
}