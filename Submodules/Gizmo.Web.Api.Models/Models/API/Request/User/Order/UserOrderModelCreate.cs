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
    public sealed class UserOrderModelCreate : IUserOrderModelCreate
    {
        #region PROPERTIES

        /// <summary>
        /// The user note of the order.
        /// </summary>
        [Key(0)]
        public string UserNote { get; set; } = string.Empty;

        /// <summary>
        /// The Id of the payment method that is preferred.
        /// </summary>
        [Key(1)]
        public int? PreferredPaymentMethodId { get; set; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [Key(2)]
        public IEnumerable<UserOrderLineModelCreate> OrderLines { get; set; } = Enumerable.Empty<UserOrderLineModelCreate>();

        #endregion
    }
}
