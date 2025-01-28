using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client reservation model.
    /// </summary>
    public interface IClientReservationModel : IWebApiModel
    {
        /// <summary>
        /// Gets next reservation id.
        /// </summary>
        public int? NextReservationId { get; init; }

        /// <summary>
        /// Gets next reservation date.
        /// </summary>
        public DateTime? NextReservationTime { get; init; }

        /// <summary>
        /// Enables blocking login on hosts with upcoming reservations.
        /// </summary>
        public bool EnableLoginBlock { get; init; }

        /// <summary>
        /// Time in minutes before upcoming reservation to block login.
        /// </summary>
        public int LoginBlockTime { get; init; }

        /// <summary>
        /// Enables unblocking login for active reservation.
        /// </summary>
        public bool EnableLoginUnblock { get; init; }

        /// <summary>
        /// Time in minutes before unblocking login for active reservation.
        /// </summary>
        public int LoginUnblockTime { get; init; }
    }
}
