using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(700, typeof(PaymentIntentCreatedEventMessage))]
    [Union(701, typeof(PaymentIntentCompletedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
