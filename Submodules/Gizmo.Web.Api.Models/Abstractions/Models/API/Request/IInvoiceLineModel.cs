namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Invoice line.
    /// </summary>
    public interface IInvoiceLineModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the bundle line this line belongs to if the line refers to a bundled product, otherwise it will be null.
        /// </summary>
        int? BundleLineId { get; set; }

        /// <summary>
        /// The total cost of this invoice line.
        /// </summary>
        decimal? Cost { get; set; }

        /// <summary>
        /// The type of the invoice line.
        /// </summary>
        LineType LineType { get; set; }

        /// <summary>
        /// The pay type of the invoice line.
        /// </summary>
        OrderLinePayType PayType { get; set; }

        /// <summary>
        /// The total amount of points the user earns from this invoice line.
        /// </summary>
        int? PointsAwardTotal { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        int PointsTotal { get; set; }

        /// <summary>
        /// The total amount excluding tax.
        /// </summary>
        decimal PreTaxTotal { get; set; }

        /// <summary>
        /// The product object attached to this invoice line if the invoice line refers to a product, otherwise it will be null.
        /// </summary>
        ProductLineModel? Product { get; set; }

        /// <summary>
        /// The name of the item in the invoice line.
        /// </summary>
        string? ProductName { get; set; }

        /// <summary>
        /// The quantity of items in the invoice line.
        /// </summary>
        decimal Quantity { get; set; }

        /// <summary>
        /// The tax rate of the invoice line.
        /// </summary>
        decimal TaxRate { get; set; }

        /// <summary>
        /// The total tax of the invoice line.
        /// </summary>
        decimal TaxTotal { get; set; }

        /// <summary>
        /// The time product object attached to this invoice line if the invoice line refers to a time product, otherwise it will be null.
        /// </summary>
        ProductLineModel? TimeProduct { get; set; }

        /// <summary>
        /// The total amount of the invoice line.
        /// </summary>
        decimal Total { get; set; }

        /// <summary>
        /// The cost of one unit in this invoice line.
        /// </summary>
        decimal? UnitCost { get; set; }

        /// <summary>
        /// The amount of points the user earns from one unit in this order line.
        /// </summary>
        int? UnitPointsAward { get; set; }

        /// <summary>
        /// The cost in points for one unit in this order line.
        /// </summary>
        int UnitPointsPrice { get; set; }

        /// <summary>
        /// The price for one unit in this invoice line.
        /// </summary>
        decimal UnitPrice { get; set; }
    }
}