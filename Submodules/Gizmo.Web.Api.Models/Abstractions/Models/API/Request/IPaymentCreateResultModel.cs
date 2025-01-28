using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Payment request creation result.
    /// </summary>
    public interface IPaymentCreateResultModel : IWebApiModel
    {
        /// <summary>
        /// Native QR Image to be used with payment apps.
        /// </summary>
        /// <remarks>
        /// This value is optional.
        /// </remarks>
        string? NativeQrImage { get; init; }

        /// <summary>
        /// Gets payment url.
        /// </summary>
        string PaymentUrl { get; init; }

        /// <summary>
        /// Gets provider used to create the request.
        /// </summary>
        Guid Provider { get; init; }

        /// <summary>
        /// Gets QR Image.
        /// </summary>
        string? QrImage { get; init; }
    }
}