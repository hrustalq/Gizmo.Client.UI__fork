namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User application link model.
    /// </summary>
    public interface IUserApplicationLinkModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the application this link belongs to.
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// The caption of the link.
        /// </summary>
        string Caption { get; init; }

        /// <summary>
        /// The description of the link.
        /// </summary>
        string Description { get; init; }

        /// <summary>
        /// The url of the link.
        /// </summary>
        string Url { get; init; }

        /// <summary>
        /// The display order of the link.
        /// </summary>
        int DisplayOrder { get; init; }
    }
}
