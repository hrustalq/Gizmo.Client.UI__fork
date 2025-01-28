using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation User.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ReservationModelUser
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user.
        /// </summary>
        [Key(0)]
        public int UserId { get; set; }

        #endregion
    }
}
