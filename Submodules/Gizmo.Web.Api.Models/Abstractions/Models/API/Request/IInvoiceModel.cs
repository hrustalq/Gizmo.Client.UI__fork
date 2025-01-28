using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Invoice.
    /// </summary>
    public interface IInvoiceModel : IWebApiModel
    {
        /// <summary>
        /// The date that the invoice was created.
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// The lines of the invoice.
        /// </summary>
        IEnumerable<InvoiceModelLine> InvoiceLines { get; set; }

        /// <summary>
        /// The payments of the invoice.
        /// </summary>
        IEnumerable<InvoicePaymentModel> InvoicePayments { get; set; }

        /// <summary>
        /// The refunds of the invoice.
        /// </summary>
        IEnumerable<InvoiceModelRefund> InvoiceRefunds { get; set; }

        /// <summary>
        /// Whether the invoice is voided.
        /// </summary>
        bool IsVoided { get; set; }

        /// <summary>
        /// The Id of the operator this invoice is associated with.
        /// </summary>
        int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the order this invoice is associated with.
        /// </summary>
        int OrderId { get; set; }

        /// <summary>
        /// The outstanding amount of the invoice.
        /// </summary>
        decimal Outstanding { get; set; }

        /// <summary>
        /// The outstanding points of the invoice.
        /// </summary>
        int OutstandingPoints { get; set; }

        /// <summary>
        /// The total points of the invoice.
        /// </summary>
        int PointsTotal { get; set; }

        /// <summary>
        /// The Id of the register this invoice is associated with.
        /// </summary>
        int? RegisterId { get; set; }

        /// <summary>
        /// The Id of the shift this invoice is associated with.
        /// </summary>
        int? ShiftId { get; set; }

        /// <summary>
        /// The status of the invoice.
        /// </summary>
        InvoiceStatus Status { get; set; }

        /// <summary>
        /// The subtotal of the invoice.
        /// </summary>
        decimal SubTotal { get; set; }

        /// <summary>
        /// The total tax of the invoice.
        /// </summary>
        decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the invoice.
        /// </summary>
        decimal Total { get; set; }

        /// <summary>
        /// The Id of the user this invoice is associated with.
        /// </summary>
        int UserId { get; set; }
    }
}