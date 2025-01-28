using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Order", "ORDER_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Order related events", "ORDER_EVENT_GROUP_DESCRIPTION")]
    [HideMetadata()]
    [EventGroup(2)]
    public abstract class OrderEventMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderEventMessageBase() : base()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets order id.
        /// </summary>
        [Key(1)]
        public int OrderId { get; set; } 

        #endregion
    }
}
