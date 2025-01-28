using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User personal file model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserPersonalFileModel : IUserPersonalFileModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The type of the personal file.
        /// </summary>
        [Key(1)]
        public PersonalUserFileType Type { get; init; }

        /// <summary>
        /// The name of the personal file.
        /// </summary>
        [Key(2)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// The caption of the personal file.
        /// </summary>
        [Key(3)]
        public string Caption { get; init; } = null!;

        /// <summary>
        /// Whether the personal file is accessible.
        /// </summary>
        [Key(4)]
        public bool Accessible { get; init; }

        /// <summary>
        /// The source path of the personal file.
        /// </summary>
        [Key(5)]
        public string Source { get; init; } = null!;

        /// <summary>
        /// The quota of the personal file.
        /// </summary>
        [Key(6)]
        public int MaxQuota { get; init; }

        /// <summary>
        /// The compression level of the personal file.
        /// </summary>
        [Key(7)]
        public int CompressionLevel { get; init; }

        #endregion
    }
}
