using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User executable personal file model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserExecutablePersonalFileModel : IUserExecutablePersonalFileModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets personal user file id.
        /// </summary>
        [Key(0)]
        public int PersonalFileId { get; init; }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [Key(1)]
        public int UseOrder { get; init; }

        #endregion
    }
}
