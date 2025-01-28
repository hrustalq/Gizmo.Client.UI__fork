using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc/>
    [Serializable, MessagePackObject]
    public sealed class UserBalanceModel : IUserBalanceModel
    {
        /// <inheritdoc/>
        [Key(0)]
        public double? AvailableCreditedTime { get; init; }

        /// <inheritdoc/>
        [Key(1)]
        public double? AvailableTime { get; init; }

        /// <inheritdoc/>
        [Key(2)]
        public decimal Deposits { get; init; }

        /// <inheritdoc/>
        [Key(3)]
        public decimal OnInvoicedUsage { get; init; }

        /// <inheritdoc/>
        [Key(4)]
        public decimal OnInvoices { get; init; }

        /// <inheritdoc/>
        [Key(5)]
        public decimal OnUninvoicedUsage { get; init; }

        /// <inheritdoc/>
        [Key(6)]
        public int Points { get; init; }

        /// <inheritdoc/>
        [Key(7)]
        public double TimeFixed { get; init; }

        /// <inheritdoc/>
        [Key(8)]
        public double TimeProduct { get; init; }

        /// <inheritdoc/>
        [IgnoreMember()]
        public decimal Balance
        {
            get { return Deposits - OnInvoices - OnUninvoicedUsage; }
        }

        /// <inheritdoc/>
        [IgnoreMember()]
        public double TimeProductBalance
        {
            get { return TimeProduct + TimeFixed; }
        }

        /// <inheritdoc/>
        [IgnoreMember()]
        public decimal UsageBalance
        {
            get { return OnInvoicedUsage + OnUninvoicedUsage; }
        }

        /// <inheritdoc/>
        [IgnoreMember()]
        public decimal TotalOutstanding
        {
            get { return OnInvoices + OnUninvoicedUsage; }
        }
    }
}
