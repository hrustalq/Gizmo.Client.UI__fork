using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host icon.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class HostIconModelCreate : IHostIconModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the host icon.
        /// </summary>
        [Key(0)]
        public byte[] Image { get; set; } = Array.Empty<byte>();

        #endregion
    }
}
