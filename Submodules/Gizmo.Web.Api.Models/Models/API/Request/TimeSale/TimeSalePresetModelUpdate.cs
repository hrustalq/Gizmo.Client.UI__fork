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
    public sealed class TimeSalePresetModelUpdate : ITimeSalePresetModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The value of the time sale preset.
        /// </summary>
        [MessagePack.Key(1)]
        [Range(0, int.MaxValue)]
        public int Value { get; set; }

        /// <summary>
        /// The display order of the time sale preset.
        /// </summary>
        [MessagePack.Key(2)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}