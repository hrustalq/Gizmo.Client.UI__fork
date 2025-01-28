using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Reservation", "RESERVATION_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Reservation related events", "RESERVATION_EVENT_GROUP_DESCRIPTION")]
    [HideMetadata()]
    [EventGroup(6)]
    public abstract class ReservationEventMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationEventMessageBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets reservation id.
        /// </summary>
        [Key(1)]
        public int ReservationId
        {
            get; protected set;
        }

        #endregion
    }
}
