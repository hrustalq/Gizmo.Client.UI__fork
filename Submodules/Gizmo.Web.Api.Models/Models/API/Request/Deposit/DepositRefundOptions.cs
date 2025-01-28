using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit refund options.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class DepositRefundOptions : IRefundOptions
    {
        #region PROPERTIES

        /// <summary>
        /// The amount to refund, if null the total amount will be refunded.
        /// </summary>
        [Key(0)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Whether to override the receipt.
        /// </summary>
        [Key(1)]
        public bool ReceiptOverride { get; set; }

        /// <summary>
        /// The Id of the payment method to use for the refund.
        /// </summary>
        [Key(2)]
        public int? RefundMethodId { get; set; }

        #endregion
    }
}
