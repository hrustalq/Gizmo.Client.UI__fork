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
    public sealed class TaxModelCreate : ITaxModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the tax.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The value of the tax.
        /// </summary>
        [MessagePack.Key(1)]
        [Range(0, 100)]
        public decimal Value { get; set; }

        #endregion
    }
}
