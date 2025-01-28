using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Stock transaction.
    /// </summary>
    public interface IStockTransactionModel : IWebApiModel
    {
        /// <summary>
        /// The date that the stock transaction was created.
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// The Id of the product this stock transaction is associated with.
        /// </summary>
        int ProductId { get; set; }

        /// <summary>
        /// The type of the stock transaction.
        /// </summary>
        StockTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the stock transaction.
        /// </summary>
        decimal Amount { get; set; }

        /// <summary>
        /// The amount of the stock after the stock transaction.
        /// </summary>
        decimal OnHand { get; set; }

        /// <summary>
        /// The Id of the operator who performed the stock transaction.
        /// </summary>
        int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift that the stock transaction belongs.
        /// </summary>
        int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register on which the stock transaction was performed.
        /// </summary>
        int? RegisterId { get; set; }
    }
}
