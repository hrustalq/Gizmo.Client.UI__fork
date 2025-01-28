namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User order invoice payment model.
    /// </summary>
    public interface IUserOrderInvoicePaymentModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the payment method this invoice payment is associated with.
        /// </summary>
        int PaymentMethodId { get; init; }
    }
}
