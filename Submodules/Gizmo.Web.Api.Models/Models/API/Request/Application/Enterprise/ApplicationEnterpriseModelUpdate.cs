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
    public sealed class ApplicationEnterpriseModelUpdate : IApplicationEnterpriseModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the enterprise.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        public string Name { get; set; } = null!;

        #endregion
    }
}
