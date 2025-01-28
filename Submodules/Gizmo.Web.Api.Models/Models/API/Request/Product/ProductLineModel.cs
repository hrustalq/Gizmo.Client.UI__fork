using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Line product.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductLineModel : IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [Key(0)]
        public int ProductId { get; set; }

        #endregion
    }
}
