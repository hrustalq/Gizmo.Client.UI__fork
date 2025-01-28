namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Payment method.
    /// </summary>
    public interface IPaymentMethodModel : IWebApiModel
    {
        /// <summary>
        /// Whether the payment method can be used by clients.
        /// </summary>
        bool AvailableInClient { get; set; }

        /// <summary>
        /// Whether the payment method can be used by manager.
        /// </summary>
        bool AvailableInManager { get; set; }

        /// <summary>
        /// The display order of the payment method.
        /// </summary>
        int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the payment method is deleted.
        /// </summary>
        bool IsDeleted { get; set; }

        /// <summary>
        /// Whether the payment method is enabled.
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// The name of the payment method.
        /// </summary>
        string Name { get; set; }
    }
}