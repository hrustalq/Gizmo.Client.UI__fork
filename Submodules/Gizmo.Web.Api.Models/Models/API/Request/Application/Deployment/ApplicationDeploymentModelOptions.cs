#nullable enable

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application deployment options.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationDeploymentModelOptions
    {
        /// <summary>
        /// Marks deployment as ignored from cleanup procedures.
        /// </summary>
        [Key(0)]
        public bool IgnoreCleanup { get; set; }

        /// <summary>
        /// Indicates that deployment should be done only on repair procedures.
        /// </summary>
        [Key(1)]
        public bool RepairOnly { get; set; }

        /// <summary>
        /// Indicates direct access to the deployment source.
        /// </summary>
        [Key(2)]
        public bool DirectAccess { get; set; }

        /// <summary>
        /// Indicates mirroring of destination directory.
        /// </summary>
        [Key(3)]
        public bool Mirror { get; set; }

        /// <summary>
        /// Indicates inclusion of sub directories.
        /// </summary>
        [Key(4)]
        public bool IncludeSubDirectories { get; set; }
    }
}