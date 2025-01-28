using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit refund options.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class RefundOptions : IRefundOptions
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the payment method to use for the refund.
        /// </summary>
        [Key(0)]
        public int? RefundMethodId { get; set; }

        #endregion
    }
}
