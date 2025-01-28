using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class DeviceHostModel : IDeviceHostModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// Gets object id. 
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Gets host id.
        /// </summary>
        [Key(1)]
        public int HostId { get; set; }

        /// <summary>
        /// Gets device id.
        /// </summary>
        [Key(2)]
        public int DeviceId { get; set; }

        #endregion
    }
}
