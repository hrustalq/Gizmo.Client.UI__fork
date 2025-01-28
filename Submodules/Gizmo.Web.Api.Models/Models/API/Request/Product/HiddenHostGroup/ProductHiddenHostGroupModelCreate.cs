using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product hidden host group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductHiddenHostGroupModelCreate : IProductHiddenHostGroupModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host group.
        /// </summary>
        [Key(0)]
        public int HostGroupId { get; set; }

        /// <summary>
        /// Whether this product is hidden in this host group.
        /// </summary>
        [Key(1)]
        public bool IsHidden { get; set; }

        #endregion
    }
}
