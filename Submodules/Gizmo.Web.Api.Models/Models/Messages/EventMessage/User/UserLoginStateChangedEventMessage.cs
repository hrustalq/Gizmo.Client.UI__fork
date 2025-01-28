using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User login state event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserLoginStateChangedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserLoginStateChangedEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets new user login state.
        /// </summary>
        [Key(2)]
        public UserLoginState NewState
        {
            get;
            init;
        }

        /// <summary>
        /// Gets old user login state.
        /// </summary>
        [Key(3)]
        public UserLoginState OldState
        {
            get;
            init;
        }

        /// <summary>
        /// Gets host id.
        /// </summary>
        [Key(4)]
        public int HostId
        {
            get;
            init;
        }

        #endregion
    }
}
