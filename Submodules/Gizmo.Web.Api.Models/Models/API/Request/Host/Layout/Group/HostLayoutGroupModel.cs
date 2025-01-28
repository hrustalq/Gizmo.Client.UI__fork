using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class HostLayoutGroupModel : IHostLayoutGroupModel, IModelIntIdentifier
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

        /// <summary>
        /// The host layouts of the host layout group.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<HostLayoutModel> HostLayouts { get; set; } = Enumerable.Empty<HostLayoutModel>();

        #endregion
    }
}