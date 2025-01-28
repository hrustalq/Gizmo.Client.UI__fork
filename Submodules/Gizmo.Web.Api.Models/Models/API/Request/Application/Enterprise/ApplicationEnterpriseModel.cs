using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application enterprise.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationEnterpriseModel : IApplicationEnterpriseModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The GUID of the application enterprise.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The name of the enterprise.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(255)]
        public string Name { get; set; } = null!;

        #endregion
    }
}
