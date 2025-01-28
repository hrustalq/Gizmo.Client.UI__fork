namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Point transaction model base.
    /// </summary>
    public interface IPointTransactionModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        int UserId { get; set; }

        /// <summary>
        /// Gets or sets transaction type.
        /// </summary>
        PointsTransactionType Type { get; set; }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        int Amount { get; set; }
    }
}
