using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Payment intent state changed.
    /// </summary>
    [MessagePackObject()]
    [System.ComponentModel.DataAnnotations.Name("Completed", "PAYMENT_INTENT_COMPLETED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates payment intent completion", "PAYMENT_INTENT_COMPLETED_EVENT_DESCRIPTION")]
    public sealed class PaymentIntentCompletedEventMessage : PaymentIntentEventMessageBase
    {        
    }
}
