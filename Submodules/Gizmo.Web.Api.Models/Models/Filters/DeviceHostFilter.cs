using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for associated hosts or devices.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class DeviceHostFilter : IModelFilter<DeviceHostModel>
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Specifies explicit object id.
        /// </summary>
        [Key(1)]
        public int? Id { get; set; }

        /// <summary>
        /// Specifies host id.
        /// </summary>
        [Key(2)]
        public int? HostId { get; set; }

        /// <summary>
        /// Specifies device id.
        /// </summary>
        [Key(3)]
        public int? DeviceId { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(4)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
