using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User order invoice payment model.
    /// </summary>
    [MessagePackObject]
    public sealed class UserOrderInvoicePaymentModel : IUserOrderInvoicePaymentModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the payment method this invoice payment is associated with.
        /// </summary>
        [Key(1)]
        public int PaymentMethodId { get; init; }

        #endregion
    }
}
