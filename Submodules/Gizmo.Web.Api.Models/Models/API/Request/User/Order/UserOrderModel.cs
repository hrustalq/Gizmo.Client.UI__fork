using System.Collections.Generic;
using System.Linq;
using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User order model.
    /// </summary>
    [MessagePackObject]
    public sealed class UserOrderModel : IUserOrderModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The status of the order.
        /// </summary>
        [Key(1)]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// The date that the order was created.
        /// </summary>
        [Key(2)]
        [Sortable("CreatedTime")]
        public DateTime Date { get; set; }

        /// <summary>
        /// The total amount of the order.
        /// </summary>
        [Key(3)]
        public decimal Total { get; set; }

        /// <summary>
        /// The total cost in points of the order.
        /// </summary>
        [Key(4)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The total amount of points the user earns from this order.
        /// </summary>
        [Key(5)]
        public int PointsAwardTotal { get; set; }

        /// <summary>
        /// The user note of the order.
        /// </summary>
        [Key(6)]
        public string UserNote { get; set; } = string.Empty;

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [Key(7)]
        public IEnumerable<UserOrderLineModel> OrderLines { get; set; } = Enumerable.Empty<UserOrderLineModel>();

        /// <summary>
        /// The invoice of the order.
        /// </summary>
        [Key(8)]
        public UserOrderInvoiceModel? Invoice { get; set; }

        #endregion
    }
}
