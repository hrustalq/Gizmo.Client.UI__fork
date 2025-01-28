using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Hdmi Device model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class DeviceModelHdmi
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets unique device ide.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(255)]
        public string? UniqueId { get; set; }

        #endregion
    }
}
