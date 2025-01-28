using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Order.
    /// </summary>
    public interface IOrderModel : IWebApiModel
    {

        /// <summary>
        /// The date that the order was created.
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// The Id of the host this order is associated with.
        /// </summary>
        int? HostId { get; set; }

        /// <summary>
        /// Whether the order is delivered.
        /// </summary>
        bool IsDelivered { get; set; }

        /// <summary>
        /// The Id of the operator this order is associated with.
        /// </summary>
        int? OperatorId { get; set; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        IEnumerable<OrderLineModel> OrderLines { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        int PointsTotal { get; set; }

        /// <summary>
        /// The Id of the register this order is associated with.
        /// </summary>
        int? RegisterId { get; set; }

        /// <summary>
        /// The Id of the shift this order is associated with.
        /// </summary>
        int? ShiftId { get; set; }

        /// <summary>
        /// The status of the order.
        /// </summary>
        OrderStatus Status { get; set; }

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

        /// <summary>
        /// The Id of the user this order is associated with.
        /// </summary>
        int UserId { get; set; }

        /// <summary>
        /// The user note of the order.
        /// </summary>
        string? UserNote { get; set; }
    }
}