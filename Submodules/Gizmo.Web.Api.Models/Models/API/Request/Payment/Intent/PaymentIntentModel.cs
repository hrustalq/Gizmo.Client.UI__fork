using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PaymentIntentModel : IPaymentIntentModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The GUID of the payment intent.
        /// </summary>
        [Key(1)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The date that the payment intent was created.
        /// </summary>
        [Key(2)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the user this payment intent is associated with.
        /// </summary>
        [Key(3)]
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the payment method this payment intent is associated with.
        /// </summary>
        [Key(4)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// The amount of the payment intent.
        /// </summary>
        [Key(5)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The state of the payment intent.
        /// </summary>
        [Key(6)]
        public PaymentIntentState State { get; set; }

        /// <summary>
        /// Provider transaction id.
        /// </summary>
        [Key(7)]
        public string? TransactionId { get; set; }

        /// <summary>
        /// Provider transaction time.
        /// </summary>
        [Key(8)]
        public DateTime? TransactionTime { get; set; }

        /// <summary>
        /// The GUID of the provider this payment intent is associated with.
        /// </summary>
        [Key(9)]
        public Guid Provider { get; set; }

        #endregion
    }
}
