using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for users.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UsersFilter : IModelFilter<UserModel>
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Return users of the specified user group.
        /// </summary>
        [MessagePack.Key(1)]
        public int? UserGroupId { get; set; }

        /// <summary>
        /// Return users with usernames that contain the specified string.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Username { get; set; }

        /// <summary>
        /// Smart card UID.
        /// </summary>
        [MessagePack.Key(3)]
        [MaxLength(255)]
        public string? SmartCardUID { get; set; }

        /// <summary>
        /// Return guest users.
        /// </summary>
        [MessagePack.Key(4)]
        public bool? IsGuest { get; set; }

        /// <summary>
        /// Return disabled users.
        /// </summary>
        [MessagePack.Key(5)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Return deleted users.
        /// </summary>
        [MessagePack.Key(6)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(7)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
