using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for payment methods.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PaymentMethodsFilter : IModelFilter<PaymentMethodModel>
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Return payment methods with names that contain the specified string.
        /// </summary>
        [Key(1)]
        public string? Name { get; set; }

        /// <summary>
        /// Return deleted payment methods.
        /// </summary>
        [Key(2)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(3)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
