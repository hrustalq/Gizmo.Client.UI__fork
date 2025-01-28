namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    public interface IHostLayoutGroupModel : IWebApiModel
    {
        /// <summary>
        /// The display order of the layout group.
        /// </summary>
        int DisplayOrder { get; set; }

        /// <summary>
        /// The name of the host group.
        /// </summary>
        string Name { get; set; }
    }
}