using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Options of model filter
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ModelFilterOptions : IModelFilterOptions
    {
        #region PROPERTIES

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(0)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
