using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for applications.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationsFilter : IModelFilter<ApplicationModel>
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Return applications with titles that contain the specified string.
        /// </summary>
        [Key(1)]
        public string? ApplicationTitle { get; set; }

        /// <summary>
        /// Return applications that belongs to the specified category.
        /// </summary>
        [Key(2)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(3)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
