using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductModel : IProductModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The type of the product.
        /// </summary>
        [MessagePack.Key(1)]
        [EnumValueValidation]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// The GUID of the product.
        /// </summary>
        [MessagePack.Key(2)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The taxes of the product.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<ProductTaxModel> ProductTaxes { get; set; } = Enumerable.Empty<ProductTaxModel>();

        /// <summary>
        /// The images of the product.
        /// </summary>
        [MessagePack.Key(4)]
        public IEnumerable<ProductImageModel> ProductImages { get; set; } = Enumerable.Empty<ProductImageModel>();

        /// <summary>
        /// The purchase availability of the product.
        /// </summary>
        [MessagePack.Key(5)]
        public ProductPurchaseAvailabilityModel? ProductPurchaseAvailability { get; set; }

        /// <summary>
        /// The Id of the product group this product belongs to.
        /// </summary>
        [MessagePack.Key(6)]
        [Sortable()]
        public int ProductGroupId { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        [MessagePack.Key(7)]
        [StringLength(45)]
        [Sortable()]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The description of the product.
        /// </summary>
        [MessagePack.Key(8)]
        [StringLength(65535)]
        public string? Description { get; set; }

        /// <summary>
        /// The price of the product.
        /// </summary>
        [MessagePack.Key(9)]
        [Sortable()]
        public decimal Price { get; set; }

        /// <summary>
        /// The cost of the product.
        /// </summary>
        [MessagePack.Key(10)]
        [Sortable()]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Disallow order from client.
        /// </summary>
        [MessagePack.Key(11)]
        public bool DisallowClientOrder { get; set; }

        /// <summary>
        /// Disallow ability of order for non users.
        /// </summary>
        [MessagePack.Key(12)]
        public bool RestrictGuestSale { get; set; }

        /// <summary>
        /// Restricts product sale.
        /// </summary>
        [MessagePack.Key(13)]
        public bool RestrictSale { get; set; }

        /// <summary>
        /// The purchase options of the product.
        /// </summary>
        [MessagePack.Key(14)]
        [EnumValueValidation]
        public PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// The amount of points the user earns when purchasing this product.
        /// </summary>
        [MessagePack.Key(15)]
        public int? Points { get; set; }

        /// <summary>
        /// The cost in points of the product.
        /// </summary>
        [MessagePack.Key(16)]
        public int? PointsPrice { get; set; }

        /// <summary>
        /// The barcode of the product.
        /// </summary>
        [MessagePack.Key(17)]
        [StringLength(255)]
        public string? Barcode { get; set; }

        /// <summary>
        /// Enable stock.
        /// </summary>
        [MessagePack.Key(18)]
        public bool EnableStock { get; set; }

        /// <summary>
        /// Disallow out of stock sale.
        /// </summary>
        [MessagePack.Key(19)]
        public bool DisallowSaleIfOutOfStock { get; set; }

        /// <summary>
        /// Alert out of stock.
        /// </summary>
        [MessagePack.Key(20)]
        public bool StockAlert { get; set; }

        /// <summary>
        /// The stock quantity threshold to alert, if the stock alert is enabled.
        /// </summary>
        [MessagePack.Key(21)]
        public decimal StockAlertThreshold { get; set; }

        /// <summary>
        /// Enable stock keeping based on different product's stock.
        /// </summary>
        [MessagePack.Key(22)]
        public bool StockTargetDifferentProduct { get; set; }

        /// <summary>
        /// The Id of the target product, if the product stock targets a different product.
        /// </summary>
        [MessagePack.Key(23)]
        public int? StockTargetProductId { get; set; }

        /// <summary>
        /// The ratio of the stock in relation to the stock of the target product, if the product stock targets a different product.
        /// </summary>
        [MessagePack.Key(24)]
        public decimal StockProductAmount { get; set; }

        /// <summary>
        /// Whether the product is deleted.
        /// </summary>
        [MessagePack.Key(25)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The product represents a service.
        /// </summary>
        [MessagePack.Key(26)]
        public bool IsService { get; set; }

        /// <summary>
        /// The display order of the product.
        /// </summary>
        [MessagePack.Key(27)]
        [Sortable()]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The time product object attached to this product if the product is a time product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(28)]
        public ProductTime? TimeProduct { get; set; }

        /// <summary>
        /// The bundle object attached to this product if the product is a bundle, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(29)]
        public Bundle? Bundle { get; set; }

        #endregion
    }
}
