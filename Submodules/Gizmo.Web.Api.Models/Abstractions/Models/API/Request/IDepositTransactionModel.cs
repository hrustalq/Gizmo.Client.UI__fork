namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Deposit transaction.
    /// </summary>
    public interface IDepositTransactionModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the user this deposit transaction is associated with.
        /// </summary>
        int UserId { get; set; }

        /// <summary>
        /// The type of the deposit transaction.
        /// </summary>
        DepositTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the deposit transaction.
        /// </summary>
        decimal Amount { get; set; }

        /// <summary>
        /// The Id of the payment method of this deposit transaction.
        /// </summary>
        int? PaymentMethodId { get; set; }
    }
}