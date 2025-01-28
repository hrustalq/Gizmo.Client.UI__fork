using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product disallowed user group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductDisallowedUserGroupModelCreate : IProductDisallowedUserGroupModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user group.
        /// </summary>
        [Key(0)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// Whether this user group is disallowed for this product.
        /// </summary>
        [Key(1)]
        public bool IsDisallowed { get; set; }

        #endregion
    }
}