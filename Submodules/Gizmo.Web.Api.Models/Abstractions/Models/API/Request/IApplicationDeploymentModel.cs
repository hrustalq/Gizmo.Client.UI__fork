namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application deployment.
    /// </summary>
    public interface IApplicationDeploymentModel : IWebApiModel
    {
        /// <summary>
        /// The deployment options of the deployment.
        /// </summary>
        ApplicationDeploymentComparisonMode ComparisonMode { get; set; }

        /// <summary>
        /// The deployment options of the deployment.
        /// </summary>
        ApplicationDeploymentModelOptions? DeploymentOptions { get; set; }

        /// <summary>
        /// The destination of the deployment.
        /// </summary>
        string Destination { get; set; }

        /// <summary>
        /// The name of the deployment.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The registry string of the deployment.
        /// </summary>
        string? RegistryString { get; set; }

        /// <summary>
        /// The source of the deployment.
        /// </summary>
        string Source { get; set; }
    }
}