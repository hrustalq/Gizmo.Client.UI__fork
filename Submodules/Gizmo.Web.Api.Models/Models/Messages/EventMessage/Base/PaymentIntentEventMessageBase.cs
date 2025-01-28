using MessagePack;
using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Payment intent event message base
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Payment intent", "PAYMENT_INTENT_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Payment intent related events", "PAYMENT_INTENT_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(7)]
    public abstract class PaymentIntentEventMessageBase : APIEventMessage
    {
        #region PROPERTIES

        /// <summary>
        /// Gets payment intent.
        /// </summary>
        [Key(1)]
        public Guid Intent
        {
            get; init;
        }

        /// <summary>
        /// Gets payment intent user id.
        /// </summary>
        [Key(2)]
        public int UserId
        {
            get; init;
        }

        #endregion
    }
}
