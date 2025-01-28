using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Calculated order.
    /// </summary>
    public interface IOrderCalculatedModel : IWebApiModel
    {
        /// <summary>
        /// The lines of the order.
        /// </summary>
        IEnumerable<OrderLineModel> OrderLines { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        int PointsTotal { get; set; }

        /// <summary>
        /// The subtotal of the order line.
        /// </summary>
        decimal SubTotal { get; set; }

        /// <summary>
        /// The total tax of the order line.
        /// </summary>
        decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the order line.
        /// </summary>
        decimal Total { get; set; }
    }
}