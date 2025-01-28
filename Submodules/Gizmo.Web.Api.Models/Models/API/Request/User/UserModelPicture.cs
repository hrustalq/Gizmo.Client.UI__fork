using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User picture.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserModelPicture
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the product image.
        /// </summary>
        [Key(0)]
        public byte[] Picture { get; set; } = Array.Empty<byte>();

        #endregion
    }
}