using System.Collections.Generic;
using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User order model.
    /// </summary>
    public interface IUserOrderModel : IWebApiModel
    {
        /// <summary>
        /// The status of the order.
        /// </summary>
        OrderStatus Status { get; set; }

        /// <summary>
        /// The date that the order was created.
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// The total amount of the order.
        /// </summary>
        decimal Total { get; set; }

        /// <summary>
        /// The total cost in points of the order.
        /// </summary>
        int PointsTotal { get; set; }

        /// <summary>
        /// The total amount of points the user earns from this order.
        /// </summary>
        int PointsAwardTotal { get; set; }

        /// <summary>
        /// The user note of the order.
        /// </summary>
        string UserNote { get; set; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        IEnumerable<UserOrderLineModel> OrderLines { get; set; }

        /// <summary>
        /// The invoice of the order.
        /// </summary>
        UserOrderInvoiceModel? Invoice { get; set; }
    }
}
