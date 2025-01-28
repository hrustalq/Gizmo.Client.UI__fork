using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent creation result.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PaymentRequestCreateResultModel : IPaymentCreateResultModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets payment url.
        /// </summary>
        [Key(0)]
        public string PaymentUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets QR Image.
        /// </summary>
        [Key(1)]
        public string? QrImage { get; init; }

        /// <summary>
        /// Native QR Image to be used with payment apps.
        /// </summary>
        /// <remarks>
        /// This value is optional.
        /// </remarks>
        [Key(2)]
        public string? NativeQrImage { get; init; }

        /// <summary>
        /// Gets provider used to create the request.
        /// </summary>
        [Key(3)]
        public Guid Provider { get; init; }

        #endregion
    }
}
