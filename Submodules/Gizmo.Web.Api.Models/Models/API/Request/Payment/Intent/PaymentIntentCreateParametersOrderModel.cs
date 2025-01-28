using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order intent creation parameters.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PaymentIntentCreateParametersOrderModel : IPaymentIntentCreateParametersModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets intent order id.
        /// </summary>
        [Key(0)]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets intent user id.
        /// </summary>
        [Key(1)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets intent amount.
        /// </summary>
        [Key(2)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        /// <remarks>
        /// The method must have payment provider set, otherwise operation will fail.
        /// </remarks>
        [Key(3)]
        public int PaymentMethodId { get; set; }

        #endregion
    }
}
