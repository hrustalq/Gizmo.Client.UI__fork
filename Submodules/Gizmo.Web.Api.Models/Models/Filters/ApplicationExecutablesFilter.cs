using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application executables.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationExecutablesFilter : IModelFilter<ApplicationExecutableModel>
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Return executables with captions that contain the specified string.
        /// </summary>
        [Key(1)]
        public string? ExecutableCaption { get; set; }

        /// <summary>
        /// Return executables that belongs to the specified application.
        /// </summary>
        [Key(2)]
        public int? ApplicationId { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(3)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
