using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group disallowed host group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserGroupDisallowedHostGroupModelUpdate : IUserGroupDisallowedHostGroupModel, IModelIntIdentifier, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the user group.
        /// </summary>
        [Key(1)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The Id of the host group.
        /// </summary>
        [Key(2)]
        public int HostGroupId { get; set; }

        /// <summary>
        /// Whether this host group is disallowed for this user group.
        /// </summary>
        [Key(3)]
        public bool IsDisallowed { get; set; }

        #endregion
    }
}