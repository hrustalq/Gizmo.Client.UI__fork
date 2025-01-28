using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable deployment.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationExecutableDeploymentModelUpdate : IApplicationExecutableDeploymentModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the executable this deployment is associated with.
        /// </summary>
        [Key(0)]
        public int ApplicationExecutableId { get; set; }

        /// <summary>
        /// The Id of the deployment associated with this application executable.
        /// </summary>
        [Key(1)]
        public int DeploymentId { get; set; }

        /// <summary>
        /// The order in which the deployment is used.
        /// </summary>
        [Key(2)]
        public int UseOrder { get; set; }

        #endregion
    }
}
