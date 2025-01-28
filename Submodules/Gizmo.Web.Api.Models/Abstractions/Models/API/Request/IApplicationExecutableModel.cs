namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application executable.
    /// </summary>
    public interface IApplicationExecutableModel : IWebApiModel
    {
        /// <summary>
        /// Whether the executable is accessible.
        /// </summary>
        bool Accessible { get; set; }

        /// <summary>
        /// The Id of the application this executable belongs to.
        /// </summary>
        int ApplicationId { get; set; }

        /// <summary>
        /// The application modes object attached to this executable.
        /// </summary>
        ApplicationModes? ApplicationModes { get; set; }

        /// <summary>
        /// The arguments of the executable.
        /// </summary>
        string? Arguments { get; set; }

        /// <summary>
        /// The caption of the executable.
        /// </summary>
        string? Caption { get; set; }

        /// <summary>
        /// The Id of the deployment profile this executable uses by default.
        /// </summary>
        int? DefaultDeploymentId { get; set; }

        /// <summary>
        /// The description of the executable.
        /// </summary>
        string? Description { get; set; }

        /// <summary>
        /// The display order of the executable.
        /// </summary>s
        int DisplayOrder { get; set; }

        /// <summary>
        /// The executable options object attached to this executable.
        /// </summary>
        ApplicationExecutableModelOptions? ExecutableOptions { get; set; }

        /// <summary>
        /// The path of the executable.
        /// </summary>
        string ExecutablePath { get; set; }

        /// <summary>
        /// The license reservation type of the executable.
        /// </summary>
        LicenseReservationType ReservationType { get; set; }

        /// <summary>
        /// The run mode of the executable.
        /// </summary>
        RunMode RunMode { get; set; }

        /// <summary>
        /// The working directory of the executable.
        /// </summary>
        string? WorkingDirectory { get; set; }
    }
}