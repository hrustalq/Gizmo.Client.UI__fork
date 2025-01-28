namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User agreement model.
    /// </summary>
    public interface IUserAgreementModel : IWebApiModel
    {
        /// <summary>
        /// The user agreement text.
        /// </summary>
        string? Agreement { get; set; }

        /// <summary>
        /// The display order of the user agreement.
        /// </summary>
        int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the user agreement should ignore state.
        /// </summary>
        bool IgnoreState { get; set; }

        /// <summary>
        /// Whether the user agreement is enabled.
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// Whether the user agreement is rejectable.
        /// </summary>
        bool IsRejectable { get; set; }

        /// <summary>
        /// The name of the user agreement.
        /// </summary>
        string? Name { get; set; }
    }
}