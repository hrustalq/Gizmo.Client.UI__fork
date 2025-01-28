using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User application model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserApplicationModel : IUserApplicationModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the application category this application belongs to.
        /// </summary>
        [Key(1)]
        public int ApplicationCategoryId { get; init; }

        /// <summary>
        /// The title of the application.
        /// </summary>
        [Key(2)]
        public string Title { get; init; } = null!;

        /// <summary>
        /// The description of the application.
        /// </summary>
        [Key(3)]
        public string Description { get; init; } = null!;

        /// <summary>
        /// The Id of the application enterprise that is the publisher of the application.
        /// </summary>
        [Key(4)]
        public int? PublisherId { get; init; }

        /// <summary>
        /// The Id of the application enterprise that is the developer of the application.
        /// </summary>
        [Key(5)]
        public int? DeveloperId { get; init; }

        /// <summary>
        /// The Id of the executable this application uses by default.
        /// </summary>
        [Key(6)]
        public int? DefaultExecutableId { get; init; }

        /// <summary>
        /// The date when the application added.
        /// </summary>
        [Key(7)]
        public DateTime AddDate { get; init; }

        /// <summary>
        /// The release date of the application.
        /// </summary>
        [Key(8)]
        public DateTime? ReleaseDate { get; init; }

        /// <summary>
        /// The Id of the application's image.
        /// </summary>
        [Key(9)]
        public int? ImageId { get; set; }

        #endregion
    }
}
