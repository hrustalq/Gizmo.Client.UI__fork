using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Attribute.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class AttributeModelCreate : IAttributeModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the attribute.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The friendly name of the attribute.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string? FriendlyName { get; set; }

        #endregion
    }
}