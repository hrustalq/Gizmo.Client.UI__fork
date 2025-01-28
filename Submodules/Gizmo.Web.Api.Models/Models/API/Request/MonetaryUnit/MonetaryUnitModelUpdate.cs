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
    public sealed class MonetaryUnitModelUpdate : IMonetaryUnitModel, IModelIntIdentifier, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the monetary unit.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The value of the monetary unit.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Value { get; set; }

        /// <summary>
        /// The display order of the monetary unit.
        /// </summary>
        [MessagePack.Key(3)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the monetary unit is deleted.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsDeleted { get; set; }

        #endregion
    }
}
