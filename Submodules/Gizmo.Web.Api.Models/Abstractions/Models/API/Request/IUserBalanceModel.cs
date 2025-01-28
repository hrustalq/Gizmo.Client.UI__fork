namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User balance model.
    /// </summary>
    public interface IUserBalanceModel :  IWebApiModel
    {
        /// <summary>
        /// Total available credited time.
        /// </summary>
        double? AvailableCreditedTime { get; init; }

        /// <summary>
        /// Total available time.
        /// </summary>
        double? AvailableTime { get; init; }

        /// <summary>
        /// Gets deposits.
        /// </summary>
        decimal Deposits { get; init; }

        /// <summary>
        /// Gets invoiced usage.
        /// </summary>
        decimal OnInvoicedUsage { get; init; }

        /// <summary>
        /// Gets on invoices.
        /// </summary>
        decimal OnInvoices { get; init; }

        /// <summary>
        /// Gets uninvoiced usage.
        /// </summary>
        decimal OnUninvoicedUsage { get; init; }

        /// <summary>
        /// Gets points.
        /// </summary>
        int Points { get; init; }

        /// <summary>
        /// Gets time fixed.
        /// </summary>
        double TimeFixed { get; init; }

        /// <summary>
        /// Gets time product.
        /// </summary>
        double TimeProduct { get; init; }

        /// <summary>
        /// Gets balance.
        /// </summary>
        decimal Balance { get; }

        /// <summary>
        /// Gets time product balance.
        /// </summary>
        double TimeProductBalance { get; }

        /// <summary>
        /// Gets total outstanding.
        /// </summary>
        decimal TotalOutstanding { get; }

        /// <summary>
        /// Gets usage balance.
        /// </summary>
        decimal UsageBalance { get; }
    }
}
