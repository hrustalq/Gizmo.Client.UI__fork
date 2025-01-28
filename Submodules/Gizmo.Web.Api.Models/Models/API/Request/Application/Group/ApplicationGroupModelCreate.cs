using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationGroupModelCreate : IApplicationGroupModel
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        #endregion
    }
}
