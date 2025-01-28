using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order status change event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class OrderStatusChangeEventMessage : OrderEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderStatusChangeEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets new status.
        /// </summary>
        [Key(2)]
        public OrderStatus NewStatus
        {
            get; init;
        }

        /// <summary>
        /// Gets old status.
        /// </summary>
        [Key(3)]
        public OrderStatus? OldStatus
        {
            get; init;
        }

        #endregion
    }
}
