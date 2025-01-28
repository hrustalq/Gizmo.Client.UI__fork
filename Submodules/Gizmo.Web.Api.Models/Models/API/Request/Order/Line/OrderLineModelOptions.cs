using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculate order line options.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class OrderLineModelOptions : IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the order line.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(0)]
        public LineType LineType { get; set; }

        /// <summary>
        /// The quantity of items in the order line.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Whether to use the custom price for this order line. 
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsCustomPrice { get; set; }

        /// <summary>
        /// The custom price of the order line.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal? CustomPrice { get; set; }

        /// <summary>
        /// The product object attached to this order line if the order line refers to a product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(4)]
        public ProductLineModel? Product { get; set; }

        /// <summary>
        /// The time product object attached to this order line if the order line refers to a time product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(5)]
        public ProductLineModel? TimeProduct { get; set; }

        /// <summary>
        /// The fixed time object attached to this order line if the order line refers to fixed time, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(6)]
        public LineFixedTime? FixedTime { get; set; }

        #endregion
    }
}