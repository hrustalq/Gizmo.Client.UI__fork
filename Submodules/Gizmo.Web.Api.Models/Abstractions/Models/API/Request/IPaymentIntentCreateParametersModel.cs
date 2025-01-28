namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Base model for payment intent creation.
    /// </summary>
    public interface IPaymentIntentCreateParametersModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets intent amount.
        /// </summary>
        decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        /// <remarks>
        /// The method must have payment provider set, otherwise operation will fail.
        /// </remarks>
        int PaymentMethodId { get; set; }

        /// <summary>
        /// Gets or sets intent user id.
        /// </summary>
        int UserId { get; set; }
    }
}