using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// New model.
    /// </summary>
    public interface INewsModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets new Id.
        /// </summary>
        int Id { get; init; }

        /// <summary>
        /// When custom template enabled user will only be able to specify entry Data.
        /// We will essentially be forcing him to provide his own visual template and data for the entry.
        /// </summary>
        bool IsCustomTemplate { get; init; }

        /// <summary>
        /// Gets or sets feed title.
        /// </summary>
        string? Title { get; init; }

        /// <summary>
        /// Gets or sets feed data.
        /// <remarks>
        /// Data can be set to plain text or html.
        /// </remarks>
        /// </summary>
        string Data { get; init; }

        /// <summary>
        /// Gets or sets start date.
        /// </summary>
        DateTime? StartDate { get; init; }

        /// <summary>
        /// Gets or sets end date.
        /// </summary>
        DateTime? EndDate { get; init; }

        /// <summary>
        /// Optional external URL or a custom command. (Action URL).
        /// </summary>
        string? Url { get; init; }

        /// <summary>
        /// Optional external media URL.
        /// </summary>
        string? MediaUrl { get; init; }

        /// <summary>
        /// Optional thumbnail URL.
        /// </summary>
        string? ThumbnailUrl { get; init; }
    }
}
