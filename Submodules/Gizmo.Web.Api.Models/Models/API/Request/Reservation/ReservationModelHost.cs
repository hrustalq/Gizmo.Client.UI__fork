using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation Host.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ReservationModelHost
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host.
        /// </summary>
        [Key(0)]
        public int HostId { get; set; }

        #endregion
    }
}
