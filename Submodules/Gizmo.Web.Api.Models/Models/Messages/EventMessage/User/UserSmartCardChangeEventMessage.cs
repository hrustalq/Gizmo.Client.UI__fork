using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User smart card change event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserSmartCardChangeEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserSmartCardChangeEventMessage() : base()
        { } 
        #endregion
    }
}
