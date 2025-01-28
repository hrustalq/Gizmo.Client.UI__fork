using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Tax.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class TaxModel : ITaxModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the tax.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The value of the tax.
        /// </summary>
        [MessagePack.Key(2)]
        [Range(0, 100)]
        public decimal Value { get; set; }

        #endregion
    }
}
