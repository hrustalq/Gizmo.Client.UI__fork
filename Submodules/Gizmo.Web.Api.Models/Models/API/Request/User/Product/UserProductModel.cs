using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User product model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserProductModel : IUserProductModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The type of the product.
        /// </summary>
        [Key(1)]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// The Id of the product group this product belongs to.
        /// </summary>
        [Key(2)]
        public int ProductGroupId { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        [Key(3)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The description of the product.
        /// </summary>
        [Key(4)]
        public string? Description { get; set; }

        /// <summary>
        /// The price of the product.
        /// </summary>
        [Key(5)]
        public decimal Price { get; set; }

        /// <summary>
        /// The cost in points of the product.
        /// </summary>
        [Key(6)]
        public int? PointsPrice { get; set; }

        /// <summary>
        /// The amount of points the user earns when purchasing this product.
        /// </summary>
        [Key(7)]
        public int? PointsAward { get; set; }

        /// <summary>
        /// The purchase options of the product.
        /// </summary>
        [Key(8)]
        public PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// The time product object attached to this product if the product is a time product, otherwise it will be null.
        /// </summary>
        [Key(9)]
        public UserProductTimeModel? TimeProduct { get; set; }

        /// <summary>
        /// The bundle object attached to this product if the product is a bundle, otherwise it will be null.
        /// </summary>
        [Key(10)]
        public UserProductBundleModel? Bundle { get; set; }

        /// <summary>
        /// The Id of the default image for this product.
        /// </summary>
        [Key(11)]
        public int? DefaultImageId { get; set; }

        /// <summary>
        /// The usage availability of the time product.
        /// </summary>
        [Key(12)]
        public ProductPurchaseAvailabilityModel? PurchaseAvailability { get; set; }

        /// <summary>
        /// Whether the product has enabled stock control and disallow sale out of stock.
        /// </summary>
        [Key(13)]
        public bool IsStockLimited { get; set; }

        /// <summary>
        /// Whether the product is restricted for guest and current user is guest.
        /// </summary>
        [Key(14)]
        public bool IsRestrictedForGuest { get; set; }

        /// <summary>
        /// Whether the product is restricted for current user group.
        /// </summary>
        [Key(15)]
        public bool IsRestrictedForUserGroup { get; set; }

        /// <summary>
        /// The list of host group where this product is hidden.
        /// </summary>
        [Key(16)]
        public IEnumerable<int> HiddenHostGroups { get; set; } = Enumerable.Empty<int>();

        /// <summary>
        /// The order options of the product.
        /// </summary>
        [Key(17)]
        public OrderOptionType OrderOptions { get; set; }

        /// <inheritdoc/>
        [Key(18)]
        public int DisplayOrder { get; set; }

        /// <inheritdoc/>
        [Key(19)]
        public DateTime CreatedTime { get; set; }

        #endregion
    }
}
