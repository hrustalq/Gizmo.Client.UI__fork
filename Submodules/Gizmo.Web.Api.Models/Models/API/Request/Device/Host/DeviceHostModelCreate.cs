using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class DeviceHostModelCreate : IDeviceHostModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets device id.
        /// </summary>
        [Key(0)]
        public int DeviceId { get; set; }

        #endregion
    }
}