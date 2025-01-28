using MessagePack;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class ReservationEventMessage : ReservationEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets reserved users.
        /// </summary>
        [Key(2)]
        public HashSet<int> Users
        {
            get; set;
        }

        /// <summary>
        /// Gets reserved hosts.
        /// </summary>
        [Key(3)]
        public HashSet<int> Hosts
        {
            get; set;
        }

        #endregion
    }
}
