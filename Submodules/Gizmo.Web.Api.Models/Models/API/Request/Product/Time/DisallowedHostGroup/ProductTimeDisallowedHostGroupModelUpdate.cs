using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product disallowed host group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductTimeDisallowedHostGroupModelUpdate : IProductTimeDisallowedHostGroupModel, IModelIntIdentifier, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the time product.
        /// </summary>
        [Key(1)]
        public int TimeProductId { get; set; }

        /// <summary>
        /// The Id of the host group.
        /// </summary>
        [Key(2)]
        public int HostGroupId { get; set; }

        /// <summary>
        /// Whether this host group is disallowed for this time product.
        /// </summary>
        [Key(3)]
        public bool IsDisallowed { get; set; }

        #endregion
    }
}