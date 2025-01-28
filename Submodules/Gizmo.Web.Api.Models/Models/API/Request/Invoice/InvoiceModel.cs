using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class InvoiceModel : IInvoiceModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The date that the invoice was created.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the order this invoice is associated with.
        /// </summary>
        [MessagePack.Key(2)]
        public int OrderId { get; set; }

        /// <summary>
        /// The Id of the user this invoice is associated with.
        /// </summary>
        [MessagePack.Key(3)]
        public int UserId { get; set; }

        /// <summary>
        /// The status of the invoice.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(4)]
        public InvoiceStatus Status { get; set; }

        /// <summary>
        /// The subtotal of the invoice.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// The total tax of the invoice.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the invoice.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal Total { get; set; }

        /// <summary>
        /// The outstanding amount of the invoice.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal Outstanding { get; set; }

        /// <summary>
        /// The total points of the invoice.
        /// </summary>
        [MessagePack.Key(9)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The outstanding points of the invoice.
        /// </summary>
        [MessagePack.Key(10)]
        public int OutstandingPoints { get; set; }

        /// <summary>
        /// The Id of the operator this invoice is associated with.
        /// </summary>
        [MessagePack.Key(11)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this invoice is associated with.
        /// </summary>
        [MessagePack.Key(12)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this invoice is associated with.
        /// </summary>
        [MessagePack.Key(13)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Whether the invoice is voided.
        /// </summary>
        [MessagePack.Key(14)]
        public bool IsVoided { get; set; }

        /// <summary>
        /// The lines of the invoice.
        /// </summary>
        [MessagePack.Key(15)]
        public IEnumerable<InvoiceModelLine> InvoiceLines { get; set; } = Enumerable.Empty<InvoiceModelLine>();

        /// <summary>
        /// The payments of the invoice.
        /// </summary>
        [MessagePack.Key(16)]
        public IEnumerable<InvoicePaymentModel> InvoicePayments { get; set; } = Enumerable.Empty<InvoicePaymentModel>();

        /// <summary>
        /// The refunds of the invoice.
        /// </summary>
        [MessagePack.Key(17)]
        public IEnumerable<InvoiceModelRefund> InvoiceRefunds { get; set; } = Enumerable.Empty<InvoiceModelRefund>();

        #endregion
    }
}
