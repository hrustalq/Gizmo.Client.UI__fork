using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Next host reservation.
    /// </summary>
    [MessagePackObject]
    public sealed class NextHostReservationModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets next reservation id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? NextReservationId { get; set; } = null!;

        /// <summary>
        /// Gets next reservation date.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime? NextReservationTime { get; set; } = null!;

        #endregion
    }
}
