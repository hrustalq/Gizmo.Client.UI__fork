using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User email changed event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserEmailChangedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserEmailChangedEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets new email value.
        /// </summary>
        [Key(2)]
        public string NewEmail
        {
            get;
            init;
        }

        /// <summary>
        /// Gets old email value.
        /// </summary>
        [Key(3)]
        public string OldEmail
        {
            get;
            init;
        }

        #endregion
    }
}
