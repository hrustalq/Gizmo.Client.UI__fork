using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application personal file.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationPersonalFileModel : IApplicationPersonalFileModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The GUID of the application personal file.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The type of the personal file.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(2)]
        public PersonalUserFileType Type { get; set; }

        /// <summary>
        /// The name of the personal file.
        /// </summary>
        [MessagePack.Key(3)]
        [StringLength(255)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The caption of the personal file.
        /// </summary>
        [MessagePack.Key(4)]
        [StringLength(255)]
        public string? Caption { get; set; }

        /// <summary>
        /// The description of the personal file.
        /// </summary>
        [MessagePack.Key(5)]
        [StringLength(255)]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the personal file is accessible.
        /// </summary>
        [MessagePack.Key(6)]
        public bool Accessible { get; set; }

        /// <summary>
        /// The source path of the personal file.
        /// </summary>
        [MessagePack.Key(7)]
        [StringLength(255)]
        public string Source { get; set; } = null!;

        /// <summary>
        /// The activation type of the personal file.
        /// </summary>
        [MessagePack.Key(8)]
        [EnumValueValidation]
        public PersonalFileActivationType Activation { get; set; }

        /// <summary>
        /// The quota of the personal file.
        /// </summary>
        [MessagePack.Key(9)]
        public int MaxQuota { get; set; }

        /// <summary>
        /// The compression level of the personal file.
        /// </summary>
        [MessagePack.Key(10)]
        public int CompressionLevel { get; set; }

        /// <summary>
        /// Whether to clean up before restore.
        /// </summary>
        [MessagePack.Key(11)]
        public bool CleanUp { get; set; }

        /// <summary>
        /// Whether to store the personal file.
        /// </summary>
        [MessagePack.Key(12)]
        public bool Store { get; set; }

        /// <summary>
        /// The directory options object attached to this personal file if the personal file type is file, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(13)]
        public ApplicationPersonalFileModelDirectoryOptions? DirectoryOptions { get; set; }

        #endregion
    }
}
