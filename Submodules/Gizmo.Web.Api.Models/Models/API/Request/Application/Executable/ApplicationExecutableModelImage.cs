using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable image.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationExecutableModelImage : IImageModel
    {
        /// <summary>
        /// The image data.
        /// </summary>
        [Key(0)]
        public byte[] Image { get; set; } = Array.Empty<byte>();
    }
}