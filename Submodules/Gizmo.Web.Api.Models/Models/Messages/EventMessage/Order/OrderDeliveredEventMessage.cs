using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order delivered event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class OrderDeliveredEventMessage : OrderEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderDeliveredEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets if order is delivered.
        /// </summary>
        [Key(2)]
        public bool IsDelivered
        {
            get; init;
        }

        /// <summary>
        /// Gets delivery time.
        /// </summary>
        [Key(3)]
        public DateTime? DeliverTime
        {
            get; init;
        }

        /// <summary>
        /// Gets current order line states.
        /// </summary>
        [Key(4)]
        public IEnumerable<OrderLineStateModel> States
        {
            get; init;
        } = Enumerable.Empty<OrderLineStateModel>();

        #endregion
    }
}
