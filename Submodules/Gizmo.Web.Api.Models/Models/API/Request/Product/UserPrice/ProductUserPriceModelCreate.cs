using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product user price.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductUserPriceModelCreate : IProductUserPriceModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user group this user price is associated with.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The price for this user price.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal? Price { get; set; }

        /// <summary>
        /// The price in points for this user price.
        /// </summary>
        [MessagePack.Key(2)]
        public int? PointsPrice { get; set; }

        /// <summary>
        /// The purchase options for this user price.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(3)]
        public PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// Whether the user prices is enabled.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}