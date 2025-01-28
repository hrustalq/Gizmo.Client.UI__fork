using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User renamed event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserRenamedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserRenamedEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets new user name.
        /// </summary>
        [Key(2)]
        public string NewUserName
        {
            get;init;
        }

        /// <summary>
        /// Gets old user name.
        /// </summary>
        [Key(3)]
        public string OldUserName
        {
            get;init;
        }

        #endregion
    }
}
