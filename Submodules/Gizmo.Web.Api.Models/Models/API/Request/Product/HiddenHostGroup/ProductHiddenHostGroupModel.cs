using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product hidden host group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductHiddenHostGroupModel : IProductHiddenHostGroupModel, IModelIntIdentifier
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
        /// The Id of the host group.
        /// </summary>
        [Key(2)]
        public int HostGroupId { get; set; }

        /// <summary>
        /// Whether this product is hidden in this host group.
        /// </summary>
        [Key(3)]
        public bool IsHidden { get; set; }

        #endregion
    }
}
