using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for monetary units.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class MonetaryUnitsFilter : IModelFilter<MonetaryUnitModel>
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Return deleted monetary units.
        /// </summary>
        [Key(1)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(2)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
