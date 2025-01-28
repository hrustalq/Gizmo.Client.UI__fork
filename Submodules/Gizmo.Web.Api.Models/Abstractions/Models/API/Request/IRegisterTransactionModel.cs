namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Register transaction.
    /// </summary>
    public interface IRegisterTransactionModel : IWebApiModel
    {
        /// <summary>
        /// The type of the register transaction.
        /// </summary>
        RegisterTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the register transaction.
        /// </summary>
        decimal Amount { get; set; }

        /// <summary>
        /// The note of the register transaction.
        /// </summary>
        string? Note { get; set; }
    }
}