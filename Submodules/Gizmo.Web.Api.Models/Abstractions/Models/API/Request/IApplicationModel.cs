using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application.
    /// </summary>
    public interface IApplicationModel : IWebApiModel
    {
        /// <summary>
        /// The age rating of the application.
        /// </summary>
        int AgeRating { get; set; }

        /// <summary>
        /// The Id of the application category this application belongs to.
        /// </summary>
        int ApplicationCategoryId { get; set; }

        /// <summary>
        /// The Id of the executable this application uses by default.
        /// </summary>
        int? DefaultExecutableId { get; set; }

        /// <summary>
        /// The description of the application.
        /// </summary>
        string? Description { get; set; }

        /// <summary>
        /// The Id of the application enterprise that is the developer of the application.
        /// </summary>
        int? DeveloperId { get; set; }

        /// <summary>
        /// The Id of the application enterprise that is the publisher of the application.
        /// </summary>
        int? PublisherId { get; set; }

        /// <summary>
        /// The release date of the application.
        /// </summary>
        DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// The title of the application.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// The version of the application.
        /// </summary>
        string? Version { get; set; }
    }
}