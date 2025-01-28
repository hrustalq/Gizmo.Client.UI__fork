using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice refund.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class InvoiceModelRefund : IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the payment method used for the refund.
        /// </summary>
        [Key(1)]
        public int RefundMethodId { get; set; }

        /// <summary>
        /// The refunded amount.
        /// </summary>
        [Key(2)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The date that the invoice refund was created.
        /// </summary>
        [Key(3)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the operator this invoice refund is associated with.
        /// </summary>
        [Key(4)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this invoice refund is associated with.
        /// </summary>
        [Key(5)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this invoice refund is associated with.
        /// </summary>
        [Key(6)]
        public int? RegisterId { get; set; }

        #endregion
    }
}