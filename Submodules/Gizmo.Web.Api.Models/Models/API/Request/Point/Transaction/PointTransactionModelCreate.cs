using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Point transaction creation model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PointTransactionModelCreate : IPointTransactionModel
    {
        #region PROPERTIES  

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets transaction type.
        /// </summary>
        [Key(1)]
        public PointsTransactionType Type { get; set; }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        [Key(2)]
        public int Amount { get; set; }

        #endregion
    }
}
