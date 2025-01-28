using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for news.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class NewsFilter : IModelFilter<NewsModel>
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Return news where the start date is greater than or equal to the specified date or is null.
        /// </summary>
        [Key(2)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Return news where the end date is less than or equal to the specified date or is null.
        /// </summary>
        [Key(3)]
        public DateTime? EndDate { get; set; }
    }
}
