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
    public sealed class ApplicationEnterpriseModelCreate : IApplicationEnterpriseModel
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the enterprise.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(255)]
        public string Name { get; set; } = null!;

        #endregion
    }
}
