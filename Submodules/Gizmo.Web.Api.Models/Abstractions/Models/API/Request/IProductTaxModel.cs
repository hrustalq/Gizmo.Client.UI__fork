namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Product tax.
    /// </summary>
    public interface IProductTaxModel : IWebApiModel
    {
        /// <summary>
        /// Indicates if product tax is enabled.
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// Tax id.
        /// </summary>
        int TaxId { get; set; }

        /// <summary>
        /// Use order.
        /// </summary>
        int UseOrder { get; set; }
    }
}