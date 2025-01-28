namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application executable deployment.
    /// </summary>
    public interface IApplicationExecutableDeploymentModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the deployment associated with this application executable.
        /// </summary>
        int DeploymentId { get; set; }

        /// <summary>
        /// The order in which the deployment is used.
        /// </summary>
        int UseOrder { get; set; }
    }
}