﻿using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for user executable personal files.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserExecutablePersonalFilesFilter : IModelFilter<UserExecutablePersonalFileModel>
    {
        #region PROPERTIES

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

        #endregion
    }
}
