using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for operators.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class OperatorsFilter : IModelFilter<OperatorModel>
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Return operators with usernames that contain the specified string.
        /// </summary>
        [Key(1)]
        public string? Username { get; set; }

        /// <summary>
        /// Return disabled operators.
        /// </summary>
        [Key(2)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Return deleted operators.
        /// </summary>
        [Key(3)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(4)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
