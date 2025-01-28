namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Asset type.
    /// </summary>
    public interface IAssetTypeModel : IWebApiModel
    {
        /// <summary>
        /// The description of the asset type.
        /// </summary>
        string? Description { get; set; }

        /// <summary>
        /// The name of the asset type.
        /// </summary>
        string Name { get; set; }
    }
}