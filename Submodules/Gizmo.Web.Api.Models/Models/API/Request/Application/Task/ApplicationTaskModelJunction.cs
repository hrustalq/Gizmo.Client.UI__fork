using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task junction.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationTaskModelJunction
    {
        #region PROPERTIES

        /// <summary>
        /// The source directory of the junction.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(255)]
        public string SourceDirectory { get; set; } = null!;

        /// <summary>
        /// The destination directory of the junction.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        public string DestinationDirectory { get; set; } = null!;

        /// <summary>
        /// Whether the junction deletes the destination.
        /// </summary>
        [MessagePack.Key(2)]
        public bool DeleteDestination { get; set; }

        #endregion
    }
}