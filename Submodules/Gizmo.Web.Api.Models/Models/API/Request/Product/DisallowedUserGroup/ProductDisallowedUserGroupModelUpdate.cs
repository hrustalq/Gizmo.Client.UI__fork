using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product disallowed user group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductDisallowedUserGroupModelUpdate : IProductDisallowedUserGroupModel, IModelIntIdentifier, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [Key(1)]
        public int ProductId { get; set; }

        /// <summary>
        /// The Id of the user group.
        /// </summary>
        [Key(2)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// Whether this user group is disallowed for this product.
        /// </summary>
        [Key(3)]
        public bool IsDisallowed { get; set; }

        #endregion
    }
}