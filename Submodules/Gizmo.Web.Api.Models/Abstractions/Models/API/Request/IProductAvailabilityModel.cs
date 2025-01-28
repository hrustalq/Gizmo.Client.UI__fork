using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Product availability.
    /// </summary>
    public interface IProductAvailabilityModel : IWebApiModel
    {
        /// <summary>
        /// Whether the product is available only for a specific date range.
        /// </summary>
        bool DateRange { get; set; }

        /// <summary>
        /// The days on which the product is available.
        /// </summary>
        IEnumerable<ProductModelAvailabilityDay> DaysAvailable { get; set; }

        /// <summary>
        /// The date from which the product stops to be available.
        /// </summary>
        DateTime? EndDate { get; set; }

        /// <summary>
        /// The date from which the product starts to be available.
        /// </summary>
        DateTime? StartDate { get; set; }

        /// <summary>
        /// Whether the product is available only for a specific time range within a day.
        /// </summary>
        bool TimeRange { get; set; }
    }
}