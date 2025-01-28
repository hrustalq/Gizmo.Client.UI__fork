using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class OrderModel : IOrderModel, IOrderCalculatedModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The invoice of the order.
        /// </summary>
        [MessagePack.Key(1)]
        public InvoiceModel? Invoice { get; set; }

        /// <summary>
        /// The date that the order was created.
        /// </summary>
        [MessagePack.Key(2)]
        [Sortable("CreatedTime")]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the user this order is associated with.
        /// </summary>
        [MessagePack.Key(3)]
        [Sortable()]
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the host this order is associated with.
        /// </summary>
        [MessagePack.Key(4)]
        [Sortable()]
        public int? HostId { get; set; }

        /// <summary>
        /// The status of the order.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(5)]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// The user note of the order.
        /// </summary>
        [MessagePack.Key(6)]
        public string? UserNote { get; set; }

        /// <summary>
        /// Whether the order is delivered.
        /// </summary>
        [MessagePack.Key(7)]
        [Sortable()]
        public bool IsDelivered { get; set; }

        /// <summary>
        /// The Id of the operator this order is associated with.
        /// </summary>
        [MessagePack.Key(8)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this order is associated with.
        /// </summary>
        [MessagePack.Key(9)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this order is associated with.
        /// </summary>
        [MessagePack.Key(10)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The subtotal of the order.
        /// </summary>
        [MessagePack.Key(11)]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// The total tax of the order.
        /// </summary>
        [MessagePack.Key(12)]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the order.
        /// </summary>
        [MessagePack.Key(13)]
        public decimal Total { get; set; }

        /// <summary>
        /// The total cost in points of the order.
        /// </summary>
        [MessagePack.Key(14)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [MessagePack.Key(15)]
        public IEnumerable<OrderLineModel> OrderLines { get; set; } = Enumerable.Empty<OrderLineModel>();

        #endregion
    }
}
