using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User product model.
    /// </summary>
    public interface IUserProductModel : IWebApiModel
    {
        /// <summary>
        /// The type of the product.
        /// </summary>
        ProductType ProductType { get; set; }

        /// <summary>
        /// The Id of the product group this product belongs to.
        /// </summary>
        int ProductGroupId { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The description of the product.
        /// </summary>
        string? Description { get; set; }

        /// <summary>
        /// The price of the product.
        /// </summary>
        decimal Price { get; set; }

        /// <summary>
        /// The cost in points of the product.
        /// </summary>
        int? PointsPrice { get; set; }

        /// <summary>
        /// The amount of points the user earns when purchasing this product.
        /// </summary>
        int? PointsAward { get; set; }

        /// <summary>
        /// The purchase options of the product.
        /// </summary>
        PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// The time product object attached to this product if the product is a time product, otherwise it will be null.
        /// </summary>
        UserProductTimeModel? TimeProduct { get; set; }

        /// <summary>
        /// The bundle object attached to this product if the product is a bundle, otherwise it will be null.
        /// </summary>
        UserProductBundleModel? Bundle { get; set; }

        /// <summary>
        /// The Id of the default image for this product.
        /// </summary>
        int? DefaultImageId { get; set; }

        /// <summary>
        /// The usage availability of the time product.
        /// </summary>
        ProductPurchaseAvailabilityModel? PurchaseAvailability { get; set; }

        /// <summary>
        /// Whether the product has enabled stock control and disallow sale out of stock.
        /// </summary>
        bool IsStockLimited { get; set; }

        /// <summary>
        /// Whether the product is restricted for guest and current user is guest.
        /// </summary>
        bool IsRestrictedForGuest { get; set; }

        /// <summary>
        /// Whether the product is restricted for current user group.
        /// </summary>
        bool IsRestrictedForUserGroup { get; set; }

        /// <summary>
        /// The list of host group where this product is hidden.
        /// </summary>
        IEnumerable<int> HiddenHostGroups { get; set; }

        /// <summary>
        /// The display order of the product.
        /// </summary>
        int DisplayOrder { get; set; }

        /// <summary>
        /// Product creation time.
        /// </summary>
        DateTime CreatedTime { get; set; }
    }
}
