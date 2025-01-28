using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application license.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationLicenseModelUpdate : IApplicationLicenseModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the license.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The plugin type name of the license.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(255)]
        public string Plugin { get; set; } = null!;

        /// <summary>
        /// The plugin assembly of the license.
        /// </summary>
        [MessagePack.Key(3)]
        [StringLength(255)]
        public string Assembly { get; set; } = null!;

        #endregion
    }
}
