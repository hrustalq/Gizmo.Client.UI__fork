#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application deployment.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationDeploymentModel : IApplicationDeploymentModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The GUID of the application deployment.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(255)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The registry string of the deployment.
        /// </summary>
        [MessagePack.Key(3)]
        [StringLength(16777215)]
        public string? RegistryString { get; set; }

        /// <summary>
        /// The source of the deployment.
        /// </summary>
        [MessagePack.Key(4)]
        [StringLength(255)]
        public string Source { get; set; } = null!;

        /// <summary>
        /// The destination of the deployment.
        /// </summary>
        [MessagePack.Key(5)]
        [StringLength(255)]
        public string Destination { get; set; } = null!;

        /// <summary>
        /// The deployment options of the deployment.
        /// </summary>
        [MessagePack.Key(6)]
        [EnumValueValidation]
        public ApplicationDeploymentComparisonMode ComparisonMode { get; set; }

        /// <summary>
        /// The deployment options of the deployment.
        /// </summary>
        [MessagePack.Key(7)]
        public ApplicationDeploymentModelOptions? DeploymentOptions { get; set; }

        #endregion
    }
}
