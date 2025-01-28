using MessagePack;
using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User enabled change event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserEnabledChangedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserEnabledChangedEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets if user is disabled.
        /// </summary>
        [Key(2)]
        public bool Disabled
        {
            get;
            init;
        }

        /// <summary>
        /// Gets enable date.
        /// </summary>
        [Key(3)]
        public DateTime? EnableDate
        {
            get;
            init;
        }

        /// <summary>
        /// Gets disabled date.
        /// </summary>
        [Key(4)]
        public DateTime? DisabledDate
        {
            get;
            init;
        }

        #endregion
    }
}
