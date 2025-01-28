using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User order invoice model.
    /// </summary>
    public interface IUserOrderInvoiceModel : IWebApiModel
    {
        /// <summary>
        /// The status of the invoice.
        /// </summary>
        InvoiceStatus Status { get; set; }

        /// <summary>
        /// The payments of the invoice.
        /// </summary>
        IEnumerable<UserOrderInvoicePaymentModel> InvoicePayments { get; set; }

        /// <summary>
        /// Whether the invoice is voided.
        /// </summary>
        bool IsVoided { get; set; }
    }
}
