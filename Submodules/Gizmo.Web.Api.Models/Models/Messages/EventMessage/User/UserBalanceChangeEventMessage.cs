using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User balance changed event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserBalanceChangeEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserBalanceChangeEventMessage() : base()
        { }
        #endregion
    }
}
