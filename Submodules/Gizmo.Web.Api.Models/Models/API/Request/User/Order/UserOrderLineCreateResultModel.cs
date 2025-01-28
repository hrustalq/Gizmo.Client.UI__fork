using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User order line create result model.
    /// </summary>
    [Serializable, MessagePackObject]
    public class UserOrderLineCreateResultModel
    {
        #region PROPERTIES

        /// <summary>
        /// The guid of the order line.
        /// </summary>
        [Key(0)]
        public Guid Guid { get; init; }

        /// <summary>
        /// The result for the specific order line.
        /// </summary>
        [Key(1)]
        public UserProductAvailabilityCheckResult Result { get; init; }

        #endregion
    }
}
