namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application executable task.
    /// </summary>
    public interface IApplicationExecutableTaskModel : IWebApiModel
    {
        /// <summary>
        /// Whether the executable is enabled.
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// Whether the task runs at Post Termination stage.
        /// </summary>
        bool PostTermination { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Deploy stage.
        /// </summary>
        bool PreDeploy { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Launch stage.
        /// </summary>
        bool PreLaunch { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Licenses Management stage.
        /// </summary>
        bool PreLicenseManagement { get; set; }

        /// <summary>
        /// The Id of the task associated with this application executable.
        /// </summary>
        int TaskId { get; set; }

        /// <summary>
        /// The order in which the task is used.
        /// </summary>
        int UseOrder { get; set; }
    }
}