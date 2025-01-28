using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User application model.
    /// </summary>
    public interface IUserApplicationModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the application category this application belongs to.
        /// </summary>
        int ApplicationCategoryId { get; init; }

        /// <summary>
        /// The title of the application.
        /// </summary>
        string Title { get; init; }

        /// <summary>
        /// The description of the application.
        /// </summary>
        string Description { get; init; }

        /// <summary>
        /// The Id of the application enterprise that is the publisher of the application.
        /// </summary>
        int? PublisherId { get; init; }

        /// <summary>
        /// The Id of the application enterprise that is the developer of the application.
        /// </summary>
        int? DeveloperId { get; init; }

        /// <summary>
        /// The Id of the executable this application uses by default.
        /// </summary>
        int? DefaultExecutableId { get; init; }

        /// <summary>
        /// The date when the application added.
        /// </summary>
        DateTime AddDate { get; init; }

        /// <summary>
        /// The release date of the application.
        /// </summary>
        DateTime? ReleaseDate { get; init; }

        /// <summary>
        /// The Id of the application's image.
        /// </summary>
        int? ImageId { get; set; }
    }
}
