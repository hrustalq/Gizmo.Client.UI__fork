using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User order invoice model.
    /// </summary>
    [MessagePackObject]
    public sealed class UserOrderInvoiceModel : IUserOrderInvoiceModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The status of the invoice.
        /// </summary>
        [Key(1)]
        public InvoiceStatus Status { get; set; }

        /// <summary>
        /// The payments of the invoice.
        /// </summary>
        [Key(2)]
        public IEnumerable<UserOrderInvoicePaymentModel> InvoicePayments { get; set; } = Enumerable.Empty<UserOrderInvoicePaymentModel>();

        /// <summary>
        /// Whether the invoice is voided.
        /// </summary>
        [Key(3)]
        public bool IsVoided { get; set; }

        #endregion
    }
}
