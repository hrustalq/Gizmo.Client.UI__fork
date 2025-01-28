using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Reservation.
    /// </summary>
    public interface IReservationModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the user this reservation is associated with.
        /// </summary>
        int? UserId { get; set; }

        /// <summary>
        /// The date of the reservation.
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// The duration of the reservation.
        /// </summary>
        int Duration { get; set; }

        /// <summary>
        /// The contact phone of the reservation.
        /// </summary>
        string? ContactPhone { get; set; }

        /// <summary>
        /// The contact email of the reservation.
        /// </summary>
        string? ContactEmail { get; set; }

        /// <summary>
        /// The note of the reservation.
        /// </summary>
        string? Note { get; set; }

        /// <summary>
        /// The pin of the reservation.
        /// </summary>
        string Pin { get; set; }

        /// <summary>
        /// The status of the reservation.
        /// </summary>
        ReservationStatus Status { get; set; }

        /// <summary>
        /// The reserved hosts by this reservation.
        /// </summary>
        IEnumerable<ReservationModelHost> Hosts { get; set; }

        /// <summary>
        /// The users of this reservation.
        /// </summary>
        IEnumerable<ReservationModelUser> Users { get; set; }
    }
}
