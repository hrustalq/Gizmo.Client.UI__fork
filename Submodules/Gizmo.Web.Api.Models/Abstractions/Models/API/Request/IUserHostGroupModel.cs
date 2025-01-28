namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User host group.
    /// </summary>
    public interface IUserHostGroupModel : IWebApiModel
    {
        /// <summary>
        /// The name of the host group.
        /// </summary>
        string Name { get; set; }
    }
}
