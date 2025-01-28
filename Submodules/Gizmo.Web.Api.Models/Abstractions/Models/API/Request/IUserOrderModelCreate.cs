using System.Collections.Generic;
using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User order model.
    /// </summary>
    public interface IUserOrderModelCreate : IWebApiModel
    {
        /// <summary>
        /// The user note of the order.
        /// </summary>
        string UserNote { get; set; }

        /// <summary>
        /// The Id of the payment method that is preferred.
        /// </summary>
        int? PreferredPaymentMethodId { get; set; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        IEnumerable<UserOrderLineModelCreate> OrderLines { get; set; }

        /*/// <summary>
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
        int PointsAwardTotal { get; set; }*/
    }
}
