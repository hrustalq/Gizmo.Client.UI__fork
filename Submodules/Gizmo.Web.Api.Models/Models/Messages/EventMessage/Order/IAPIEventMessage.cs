using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(200, typeof(OrderDeliveredEventMessage))]
    [Union(201, typeof(OrderInvoicedEventMessage))]
    [Union(202, typeof(OrderInvoicePaymentEventMessage))]
    [Union(203, typeof(OrderStatusChangeEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
