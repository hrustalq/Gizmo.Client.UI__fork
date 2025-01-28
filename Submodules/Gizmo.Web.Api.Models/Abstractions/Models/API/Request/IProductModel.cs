namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Product.
    /// </summary>
    public interface IProductModel : IWebApiModel
    {
        /// <summary>
        /// The barcode of the product.
        /// </summary>
        string? Barcode { get; set; }

        /// <summary>
        /// The bundle object attached to this product if the product is a bundle, otherwise it will be null.
        /// </summary>
        Bundle? Bundle { get; set; }

        /// <summary>
        /// The cost of the product.
        /// </summary>
        decimal? Cost { get; set; }

        /// <summary>
        /// The description of the product.
        /// </summary>
        string? Description { get; set; }

        /// <summary>
        /// Disallow order from client.
        /// </summary>
        bool DisallowClientOrder { get; set; }

        /// <summary>
        /// Disallow out of stock sale.
        /// </summary>
        bool DisallowSaleIfOutOfStock { get; set; }

        /// <summary>
        /// The display order of the product.
        /// </summary>
        int DisplayOrder { get; set; }

        /// <summary>
        /// Enable stock.
        /// </summary>
        bool EnableStock { get; set; }

        /// <summary>
        /// Whether the product is deleted.
        /// </summary>
        bool IsDeleted { get; set; }

        /// <summary>
        /// The product represents a service.
        /// </summary>
        bool IsService { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The amount of points the user earns when purchasing this product.
        /// </summary>
        int? Points { get; set; }

        /// <summary>
        /// The cost in points of the product.
        /// </summary>
        int? PointsPrice { get; set; }

        /// <summary>
        /// The price of the product.
        /// </summary>
        decimal Price { get; set; }

        /// <summary>
        /// The Id of the product group this product belongs to.
        /// </summary>
        int ProductGroupId { get; set; }

        /// <summary>
        /// The purchase options of the product.
        /// </summary>
        PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// Disallow ability of order for non users.
        /// </summary>
        bool RestrictGuestSale { get; set; }

        /// <summary>
        /// Restricts product sale.
        /// </summary>
        bool RestrictSale { get; set; }

        /// <summary>
        /// Alert out of stock.
        /// </summary>
        bool StockAlert { get; set; }

        /// <summary>
        /// The stock quantity threshold to alert, if the stock alert is enabled.
        /// </summary>
        decimal StockAlertThreshold { get; set; }

        /// <summary>
        /// The ratio of the stock in relation to the stock of the target product, if the product stock targets a different product.
        /// </summary>
        decimal StockProductAmount { get; set; }

        /// <summary>
        /// Enable stock keeping based on different product's stock.
        /// </summary>
        bool StockTargetDifferentProduct { get; set; }

        /// <summary>
        /// The Id of the target product, if the product stock targets a different product.
        /// </summary>
        int? StockTargetProductId { get; set; }

        /// <summary>
        /// The time product object attached to this product if the product is a time product, otherwise it will be null.
        /// </summary>
        ProductTime? TimeProduct { get; set; }
    }
}