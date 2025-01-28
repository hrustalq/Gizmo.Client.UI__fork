namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Asset.
    /// </summary>
    public interface IAssetModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the asset type this asset belongs to.
        /// </summary>
        int AssetTypeId { get; set; }

        /// <summary>
        /// The barcode of the asset.
        /// </summary>
        string? Barcode { get; set; }

        /// <summary>
        /// Whether the asset is enabled.
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// The number of the asset.
        /// </summary>
        int Number { get; set; }

        /// <summary>
        /// The serial number of the asset.
        /// </summary>
        string? SerialNumber { get; set; }

        /// <summary>
        /// The smart card unique id of the asset.
        /// </summary>
        string? SmartCardUid { get; set; }

        /// <summary>
        /// The tag of the asset.
        /// </summary>
        string? Tag { get; set; }
    }
}