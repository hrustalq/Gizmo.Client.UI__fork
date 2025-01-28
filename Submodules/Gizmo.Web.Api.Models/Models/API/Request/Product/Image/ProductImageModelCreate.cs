using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product image.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductImageModelCreate : IProductImageModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the product image.
        /// </summary>
        [Key(0)]
        public byte[] Image { get; set; } = Array.Empty<byte>();

        #endregion
    }
}