using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User order create result model.
    /// </summary>
    [Serializable, MessagePackObject]
    public class UserOrderCreateResultModel
    {
        #region PROPERTIES

        /// <summary>
        /// Order result.
        /// </summary>
        [Key(0)]
        public OrderResult Result { get; init; }

        /// <summary>
        /// Fail reason.
        /// </summary>
        [Key(1)]
        public OrderFailReason FailReason { get; init; }

        /// <summary>
        /// The Id of the newly created object if was successfull.
        /// </summary>
        [Key(2)]
        public int? Id { get; init; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [Key(3)]
        public IEnumerable<UserOrderLineCreateResultModel> OrderLines { get; set; } = Enumerable.Empty<UserOrderLineCreateResultModel>();

        #endregion
    }
}
