using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product tax.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductTaxModel : IProductTaxModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the product this tax belongs to.
        /// </summary>
        [Key(1)]
        public int ProductId { get; set; }

        /// <summary>
        /// Tax id.
        /// </summary>
        [Key(2)]
        public int TaxId { get; set; }

        /// <summary>
        /// Use order.
        /// </summary>
        [Key(3)]
        public int UseOrder { get; set; }

        /// <summary>
        /// Indicates if product tax is enabled.
        /// </summary>
        [Key(4)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}