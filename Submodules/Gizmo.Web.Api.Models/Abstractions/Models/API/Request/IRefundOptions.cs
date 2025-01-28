namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Refund options.
    /// </summary>
    public interface IRefundOptions
    {
        /// <summary>
        /// The Id of the payment method to use for the refund.
        /// </summary>
        int? RefundMethodId { get; set; }
    }
}