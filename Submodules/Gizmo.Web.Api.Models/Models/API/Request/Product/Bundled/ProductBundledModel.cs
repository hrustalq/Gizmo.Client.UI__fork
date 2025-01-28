using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundled product.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductBundledModel : IProductBundledModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [MessagePack.Key(1)]
        public int ProductId { get; set; }

        /// <summary>
        /// The quantity of the product within the bundle.
        /// </summary>
        [MessagePack.Key(2)]
        [Range(1, int.MaxValue)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The unit price of the product within the bundle.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal UnitPrice { get; set; }

        #endregion
    }
}