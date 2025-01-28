using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Payment intent.
    /// </summary>
    public interface IPaymentIntentModel : IWebApiModel
    {
        /// <summary>
        /// The amount of the payment intent.
        /// </summary>
        decimal Amount { get; set; }

        /// <summary>
        /// The date that the payment intent was created.
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// The Id of the payment method this payment intent is associated with.
        /// </summary>
        int PaymentMethodId { get; set; }

        /// <summary>
        /// The GUID of the provider this payment intent is associated with.
        /// </summary>
        Guid Provider { get; set; }

        /// <summary>
        /// The state of the payment intent.
        /// </summary>
        PaymentIntentState State { get; set; }

        /// <summary>
        /// Provider transaction id.
        /// </summary>
        string? TransactionId { get; set; }

        /// <summary>
        /// Provider transaction time.
        /// </summary>
        DateTime? TransactionTime { get; set; }

        /// <summary>
        /// The Id of the user this payment intent is associated with.
        /// </summary>
        int UserId { get; set; }
    }
}