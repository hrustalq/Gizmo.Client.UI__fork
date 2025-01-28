using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable task.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationExecutableTaskModelCreate : IApplicationExecutableTaskModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the task associated with this application executable.
        /// </summary>
        [Key(0)]
        public int TaskId { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Deploy stage.
        /// </summary>
        [Key(1)]
        public bool PreDeploy { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Licenses Management stage.
        /// </summary>
        [Key(2)]
        public bool PreLicenseManagement { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Launch stage.
        /// </summary>
        [Key(3)]
        public bool PreLaunch { get; set; }

        /// <summary>
        /// Whether the task runs at Post Termination stage.
        /// </summary>
        [Key(4)]
        public bool PostTermination { get; set; }

        /// <summary>
        /// The order in which the task is used.
        /// </summary>
        [Key(5)]
        public int UseOrder { get; set; }

        /// <summary>
        /// Whether the executable is enabled.
        /// </summary>
        [Key(6)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}
