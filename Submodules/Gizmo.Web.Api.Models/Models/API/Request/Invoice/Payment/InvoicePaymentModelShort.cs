using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice payment.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class InvoicePaymentModelShort : IInvoicePaymentModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the payment method this invoice payment is associated with.
        /// </summary>
        [Key(0)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// The amount of the invoice payment.
        /// </summary>
        [Key(1)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The amount received for the invoice payment.
        /// </summary>
        [Key(2)]
        public decimal AmountReceived { get; set; }

        #endregion
    }
}
