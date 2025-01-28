using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ReservationModelCreate : IReservationModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user this reservation is associated with.
        /// </summary>
        [MessagePack.Key(0)]
        public int? UserId { get; set; }

        /// <summary>
        /// The date of the reservation.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The duration of the reservation.
        /// </summary>
        [MessagePack.Key(2)]
        [Range(1, int.MaxValue)]
        public int Duration { get; set; }

        /// <summary>
        /// The contact phone of the reservation.
        /// </summary>
        [MessagePack.Key(3)]
        [StringLength(20)]
        public string? ContactPhone { get; set; }

        /// <summary>
        /// The contact email of the reservation.
        /// </summary>
        [MessagePack.Key(4)]
        [StringLength(254)]
        [EmailNullEmptyValidation]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// The note of the reservation.
        /// </summary>
        [MessagePack.Key(5)]
        public string? Note { get; set; }

        /// <summary>
        /// The pin of the reservation.
        /// </summary>
        [MessagePack.Key(6)]
        [StringLength(6)]
        public string Pin { get; set; } = null!;

        /// <summary>
        /// The status of the reservation.
        /// </summary>
        [MessagePack.Key(7)]
        [EnumValueValidation]
        public ReservationStatus Status { get; set; }

        /// <summary>
        /// The reserved hosts by this reservation.
        /// </summary>
        [MessagePack.Key(8)]
        public IEnumerable<ReservationModelHost> Hosts { get; set; } = Enumerable.Empty<ReservationModelHost>();

        /// <summary>
        /// The users of this reservation.
        /// </summary>
        [MessagePack.Key(9)]
        public IEnumerable<ReservationModelUser> Users { get; set; } = Enumerable.Empty<ReservationModelUser>();

        #endregion
    }
}
