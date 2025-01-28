namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Feed model.
    /// </summary>
    public interface IFeedModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets feed title.
        /// </summary>
        public string Title { get; init; }

        /// <summary>
        /// Gets or sets maximum results.
        /// </summary>
        public int Maximum { get; init; }

        /// <summary>
        /// Gets or sets feed url.
        /// </summary>
        public string Url { get; init; }

        /// <summary>
        /// Gets or sets feed Id.
        /// </summary>
        public int Id { get; init; }
    }
}
