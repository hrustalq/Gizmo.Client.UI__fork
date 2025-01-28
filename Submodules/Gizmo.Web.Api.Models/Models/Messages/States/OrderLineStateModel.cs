using MessagePack;
using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order line state model.
    /// </summary>
    [MessagePackObject()]
    public class OrderLineStateModel
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderLineStateModel()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets order line id.
        /// </summary>
        [Key(0)]
        public int OrderLineId
        {
            get; set;
        }

        /// <summary>
        /// Gets if devlivered.
        /// </summary>
        [Key(1)]
        public bool IsDelivered
        {
            get; set;
        }

        /// <summary>
        /// Gets devlivered quantity.
        /// </summary>
        [Key(2)]
        public decimal DeliveredQuantity
        {
            get; set;
        }

        /// <summary>
        /// Gets delivery time.
        /// </summary>
        [Key(3)]
        public DateTime? DeliverTime
        {
            get; set;
        }

        #endregion
    }
}
