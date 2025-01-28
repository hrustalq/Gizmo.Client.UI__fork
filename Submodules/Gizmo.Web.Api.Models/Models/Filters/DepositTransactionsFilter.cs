using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for deposit transactions.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class DepositTransactionsFilter : IModelFilter<DepositTransactionModel>
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Return deposit transactions where the date greater than or equal to the specified date.
        /// </summary>
        [Key(1)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return deposit transactions where the date less than or equal to the specified date.
        /// </summary>
        [Key(2)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return deposit transactions of the specified user.
        /// </summary>
        [Key(3)]
        public int? UserId { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(4)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
