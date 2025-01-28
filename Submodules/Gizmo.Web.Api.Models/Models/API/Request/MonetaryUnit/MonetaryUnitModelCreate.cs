using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Monetary unit.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class MonetaryUnitModelCreate : IMonetaryUnitModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the monetary unit.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The value of the monetary unit.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Value { get; set; }

        /// <summary>
        /// The display order of the monetary unit.
        /// </summary>
        [MessagePack.Key(2)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the monetary unit is deleted.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsDeleted { get; set; }

        #endregion
    }
}
