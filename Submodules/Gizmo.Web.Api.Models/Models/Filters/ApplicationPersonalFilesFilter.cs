using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application personal files.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationPersonalFilesFilter : IModelFilter<ApplicationPersonalFileModel>
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Return personal files with names that contain the specified string.
        /// </summary>
        [Key(1)]
        public string? PersonalFileName { get; set; }

        /// <summary>
        /// Return personal files with captions that contain the specified string.
        /// </summary>
        [Key(2)]
        public string? PersonalFileCaption { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(3)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
