using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product image.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductImageModel : IProductImageModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the product this image belongs to.
        /// </summary>
        [Key(1)]
        public int ProductId { get; set; }

        /// <summary>
        /// The image data of the product image.
        /// </summary>
        [Key(2)]
        public byte[] Image { get; set; } = Array.Empty<byte>();

        #endregion
    }
}