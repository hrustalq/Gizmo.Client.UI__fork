using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User enable negative balance changed event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserEnableNegativeBalanceEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserEnableNegativeBalanceEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Gets if negative balance allowed for user.
        /// </summary>
        [Key(2)]
        public bool? Enabled
        {
            get; init;
        }
        #endregion
    }
}
