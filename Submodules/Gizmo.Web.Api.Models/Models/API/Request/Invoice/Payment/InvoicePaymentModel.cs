using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice payment.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class InvoicePaymentModel : IInvoicePaymentModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The date that the invoice payment was created.
        /// </summary>
        [Key(1)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the invoice this invoice payment is associated with.
        /// </summary>
        [Key(2)]
        public int InvoiceId { get; set; }

        /// <summary>
        /// The Id of the operator this invoice payment is associated with.
        /// </summary>
        [Key(3)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this invoice payment is associated with.
        /// </summary>
        [Key(4)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this invoice payment is associated with.
        /// </summary>
        [Key(5)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The Id of the payment method this invoice payment is associated with.
        /// </summary>
        [Key(6)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// The amount of the invoice payment.
        /// </summary>
        [Key(7)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The amount received for the invoice payment.
        /// </summary>
        [Key(8)]
        public decimal AmountReceived { get; set; }

        #endregion
    }
}