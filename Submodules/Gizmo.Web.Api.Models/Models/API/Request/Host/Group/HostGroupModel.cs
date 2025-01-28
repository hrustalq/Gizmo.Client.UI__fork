using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class HostGroupModel : IHostGroupModel, IModelIntIdentifier
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
        /// The name of the skin this host group uses by default.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(255)]
        public string? SkinName { get; set; }

        /// <summary>
        /// The Id of the application profile this host group is associated with.
        /// </summary>
        [MessagePack.Key(3)]
        public int? ApplicationGroupId { get; set; }

        /// <summary>
        /// The Id of the security profile this host group is associated with.
        /// </summary>
        [MessagePack.Key(4)]
        public int? SecurityProfileId { get; set; }

        /// <summary>
        /// The Id of the guest group this host group uses by default.
        /// </summary>
        [MessagePack.Key(5)]
        public int? DefaultGuestGroupId { get; set; }

        #endregion
    }
}