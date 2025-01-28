using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Verification result for mobile phones.
    /// </summary>
    public interface ITokenResultModelWithMobileCode<TResultCode> : ITokenResultModelWithCode<TResultCode> where TResultCode : Enum
    {
        /// <summary>
        /// Gets or sets mobile phone.
        /// </summary>
        string MobilePhone { get; set; }

        /// <summary>
        /// Gets confirmation code delivery method.
        /// </summary>
        /// <remarks>
        /// The default value is <see cref="ConfirmationCodeDeliveryMethod.Undetermined"/>.
        /// </remarks>
        ConfirmationCodeDeliveryMethod DeliveryMethod { get; init; }
    }
}