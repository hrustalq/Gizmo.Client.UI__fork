using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order invoiced event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class OrderInvoicedEventMessage : OrderEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderInvoicedEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets invoice id.
        /// </summary>
        [Key(2)]
        public int InvoiceId
        {
            get; init;
        }

        #endregion
    }
}
