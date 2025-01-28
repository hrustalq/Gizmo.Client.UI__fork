using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for orders.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class OrdersFilter : IModelFilter<OrderModel>
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Return orders where the date greater than or equal to the specified date.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return orders where the date less than or equal to the specified date.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return orders with the specified order status.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(3)]
        public OrderStatus? Status { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(4)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
