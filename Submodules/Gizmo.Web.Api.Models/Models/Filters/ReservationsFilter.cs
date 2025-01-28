using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for reservations.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ReservationsFilter : IModelFilter<ReservationModel>
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Return reservations where the date greater than or equal to the specified date.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return reservations where the date less than or equal to the specified date.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return reservations with the specified reservation status.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(3)]
        public ReservationStatus? Status { get; set; }

        /// <summary>
        /// Return reservations of the specified user.
        /// </summary>
        [MessagePack.Key(4)]
        public int? UserId { get; set; }

        /// <summary>
        /// Return reservations with the specified contact phone.
        /// </summary>
        [StringLength(20)]
        [MessagePack.Key(5)]
        public string? ContactPhone { get; set; }

        /// <summary>
        /// Return reservations with the specified contact email.
        /// </summary>
        [StringLength(254)]
        [MessagePack.Key(6)]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(7)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
