using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Invoice order options.
    /// </summary>
    public interface IInvoiceOrderOptionsModel : IWebApiModel
    {
        /// <summary>
        /// The list of payments for the invoice.
        /// </summary>
        IEnumerable<InvoicePaymentModelShort> Payments { get; set; }
    }
}