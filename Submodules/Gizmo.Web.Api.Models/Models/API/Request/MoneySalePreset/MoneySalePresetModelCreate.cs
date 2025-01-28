using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Money sale preset.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class MoneySalePresetModelCreate : IMoneySalePresetModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The value of the money sale preset.
        /// </summary>
        [Range(0.0, 1_000_000_000_000)]
        [MessagePack.Key(0)]
        public decimal Value { get; set; }

        /// <summary>
        /// The display order of the money sale preset.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}
