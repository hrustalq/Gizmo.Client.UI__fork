using System;
using System.ComponentModel.DataAnnotations;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device update model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class DeviceModelUpdate : IDeviceModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Gets or sets device name.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets if device is enabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The hdmi device object attached to this device if the device is an hdmi device, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(3)]
        public DeviceModelHdmi? HdmiDevice { get; set; }

        #endregion
    }
}
