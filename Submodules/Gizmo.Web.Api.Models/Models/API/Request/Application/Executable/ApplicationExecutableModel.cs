
using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationExecutableModel : IApplicationExecutableModel, IModelIntIdentifier
    {

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The GUID of the application executable.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid Guid { get; set; }

        /// <summary>
        /// Whether the executable is accessible.
        /// </summary>
        [MessagePack.Key(2)]
        public bool Accessible { get; set; }

        /// <summary>
        /// The caption of the executable.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(3)]
        public string? Caption { get; set; }

        /// <summary>
        /// The description of the executable.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(4)]
        public string? Description { get; set; }

        /// <summary>
        /// The application modes object attached to this executable.
        /// </summary>
        [MessagePack.Key(5)]
        public ApplicationModes? ApplicationModes { get; set; }

        /// <summary>
        /// The path of the executable.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(6)]
        public string ExecutablePath { get; set; } = null!;

        /// <summary>
        /// The working directory of the executable.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(7)]
        public string? WorkingDirectory { get; set; }

        /// <summary>
        /// The arguments of the executable.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(8)]
        public string? Arguments { get; set; }

        /// <summary>
        /// The run mode of the executable.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(9)]
        public RunMode RunMode { get; set; }

        /// <summary>
        /// The license reservation type of the executable.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(10)]
        public LicenseReservationType ReservationType { get; set; }

        /// <summary>
        /// The executable options object attached to this executable.
        /// </summary>
        [MessagePack.Key(11)]
        public ApplicationExecutableModelOptions? ExecutableOptions { get; set; }

        /// <summary>
        /// The display order of the executable.
        /// </summary>
        [MessagePack.Key(12)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The Id of the application this executable belongs to.
        /// </summary>
        [MessagePack.Key(13)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The Id of the deployment profile this executable uses by default.
        /// </summary>
        [MessagePack.Key(14)]
        public int? DefaultDeploymentId { get; set; }

    }
}
