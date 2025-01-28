#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationModelUpdate : IApplicationModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The title of the application.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        public string Title { get; set; } = null!;

        /// <summary>
        /// The description of the application.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Description { get; set; }

        /// <summary>
        /// The version of the application.
        /// </summary>
        [MessagePack.Key(3)]
        [StringLength(45)]
        public string? Version { get; set; }

        /// <summary>
        /// The Id of the application category this application belongs to.
        /// </summary>
        [MessagePack.Key(4)]
        public int ApplicationCategoryId { get; set; }

        /// <summary>
        /// The Id of the application enterprise that is the developer of the application.
        /// </summary>
        [MessagePack.Key(5)]
        public int? DeveloperId { get; set; }

        /// <summary>
        /// The Id of the application enterprise that is the publisher of the application.
        /// </summary>
        [MessagePack.Key(6)]
        public int? PublisherId { get; set; }

        /// <summary>
        /// The age rating of the application.
        /// </summary>
        [MessagePack.Key(7)]
        public int AgeRating { get; set; }

        /// <summary>
        /// The release date of the application.
        /// </summary>
        [MessagePack.Key(8)]
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// The Id of the executable this application uses by default.
        /// </summary>
        [MessagePack.Key(9)]
        public int? DefaultExecutableId { get; set; }

        #endregion
    }
}
