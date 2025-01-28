using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable options.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationExecutableModelOptions
    {
        /// <summary>
        /// Auto launch.
        /// </summary>
        [Key(0)]
        public bool AutoLaunch { get; set; }

        /// <summary>
        /// Monitor children.
        /// </summary>
        [Key(1)]
        public bool MonitorChildren { get; set; }

        /// <summary>
        /// Multi run.
        /// </summary>
        [Key(2)]
        public bool MultiRun { get; set; }

        /// <summary>
        /// Kill children.
        /// </summary>
        [Key(3)]
        public bool KillChildren { get; set; }

        /// <summary>
        /// Quick launch.
        /// </summary>
        [Key(4)]
        public bool QuickLaunch { get; set; }

        /// <summary>
        /// Shell execute.
        /// </summary>
        [Key(5)]
        public bool ShellExecute { get; set; }

        /// <summary>
        /// Ignore concurrent execution limit.
        /// </summary>
        [Key(6)]
        public bool IgnoreConcurrentExecutionLimit { get; set; }
    }
}