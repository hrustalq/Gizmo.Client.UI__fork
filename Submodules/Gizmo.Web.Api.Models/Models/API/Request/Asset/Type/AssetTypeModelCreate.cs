using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset type.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class AssetTypeModelCreate : IAssetTypeModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the asset type.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The description of the asset type.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Description { get; set; }

        #endregion
    }
}