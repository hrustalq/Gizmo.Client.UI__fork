using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class AssetModel : IAssetModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the asset type this asset belongs to.
        /// </summary>
        [MessagePack.Key(1)]
        public int AssetTypeId { get; set; }

        /// <summary>
        /// The number of the asset.
        /// </summary>
        [MessagePack.Key(2)]
        public int Number { get; set; }

        /// <summary>
        /// The tag of the asset.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(3)]
        public string? Tag { get; set; }

        /// <summary>
        /// The smart card unique id of the asset.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(4)]
        public string? SmartCardUid { get; set; }

        /// <summary>
        /// The barcode of the asset.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(5)]
        public string? Barcode { get; set; }

        /// <summary>
        /// The serial number of the asset.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(6)]
        public string? SerialNumber { get; set; }

        /// <summary>
        /// Whether the asset is enabled.
        /// </summary>
        [MessagePack.Key(7)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}