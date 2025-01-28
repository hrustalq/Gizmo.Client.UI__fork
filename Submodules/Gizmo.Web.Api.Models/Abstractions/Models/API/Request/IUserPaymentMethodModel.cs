namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User payment method model.
    /// </summary>
    public interface IUserPaymentMethodModel : IWebApiModel
    {
        /// <summary>
        /// The name of the payment method.
        /// </summary>
        string Name { get; init; }

        /// <summary>
        /// The display order of the payment method.
        /// </summary>
        int DisplayOrder { get; init; }

        /// <summary>
        /// Payment method is online.
        /// </summary>
        bool IsOnline { get; init; }
    }
}
