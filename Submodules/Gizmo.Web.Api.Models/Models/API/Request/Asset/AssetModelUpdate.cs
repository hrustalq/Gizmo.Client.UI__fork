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
    public sealed class AssetModelUpdate : IAssetModel, IModelIntIdentifier, IUriParametersQuery
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
        [MessagePack.Key(3)]
        [StringLength(255)]
        public string? Tag { get; set; }

        /// <summary>
        /// The smart card unique id of the asset.
        /// </summary>
        [MessagePack.Key(4)]
        [StringLength(255)]
        public string? SmartCardUid { get; set; }

        /// <summary>
        /// The barcode of the asset.
        /// </summary>
        [MessagePack.Key(5)]
        [StringLength(255)]
        public string? Barcode { get; set; }

        /// <summary>
        /// The serial number of the asset.
        /// </summary>
        [MessagePack.Key(6)]
        [StringLength(255)]
        public string? SerialNumber { get; set; }

        /// <summary>
        /// Whether the asset is enabled.
        /// </summary>
        [MessagePack.Key(7)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}