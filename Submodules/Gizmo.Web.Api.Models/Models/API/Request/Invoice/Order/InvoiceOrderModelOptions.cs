using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice order options.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class InvoiceOrderModelOptions : IInvoiceOrderOptionsModel
    {
        #region PROPERTIES

        /// <summary>
        /// The list of payments for the invoice.
        /// </summary>
        [Key(0)]
        public IEnumerable<InvoicePaymentModelShort> Payments { get; set; } = Enumerable.Empty<InvoicePaymentModelShort>();

        #endregion
    }
}