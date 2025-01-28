namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Billing profile.
    /// </summary>
    public interface IBillingProfileModel : IWebApiModel
    {
        /// <summary>
        /// The default rate of the billing profile.
        /// </summary>
        BillingProfileRateModel? DefaultRate { get; set; }

        /// <summary>
        /// The name of the billing profile.
        /// </summary>
        string Name { get; set; }
    }
}