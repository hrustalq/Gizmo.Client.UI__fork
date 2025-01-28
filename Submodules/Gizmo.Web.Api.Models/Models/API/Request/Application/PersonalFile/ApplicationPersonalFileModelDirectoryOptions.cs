using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application personal file directory options.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationPersonalFileModelDirectoryOptions
    {
        #region PROPERTIES

        /// <summary>
        /// Whether to include subdirectories.
        /// </summary>
        [Key(0)]
        public bool IncludeSubDirectories { get; set; }

        /// <summary>
        /// The list of files that should be excluded.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [Key(1)]
        public string? ExcludeFiles { get; set; }

        /// <summary>
        /// The list of directories that should be excluded.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [Key(2)]
        public string? ExcludeDirectories { get; set; }

        /// <summary>
        /// The list of files that should be included.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [Key(3)]
        public string? IncludeFiles { get; set; }

        /// <summary>
        /// The list of directories that should be included.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [Key(4)]
        public string? IncludeDirectories { get; set; }

        #endregion
    }
}