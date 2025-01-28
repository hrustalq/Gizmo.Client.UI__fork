using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class HostLayoutGroupModelUpdate : IHostLayoutGroupModel, IModelIntIdentifier, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the host group.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The display order of the layout group.
        /// </summary>
        [MessagePack.Key(2)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}