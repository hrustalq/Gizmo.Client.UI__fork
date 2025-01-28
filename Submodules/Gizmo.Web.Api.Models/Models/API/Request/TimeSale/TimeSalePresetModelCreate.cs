using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time sale preset.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class TimeSalePresetModelCreate : ITimeSalePresetModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The value of the time sale preset.
        /// </summary>
        [MessagePack.Key(0)]
        [Range(0, int.MaxValue)]
        public int Value { get; set; }

        /// <summary>
        /// The display order of the time sale preset.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}
