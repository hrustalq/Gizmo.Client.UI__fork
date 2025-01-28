using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product availability day.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductModelAvailabilityDay
    {
        #region PROPERTIES

        /// <summary>
        /// The day of the week.
        /// </summary>
        [Key(0)]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// The timespans during which the product is available for this day.
        /// </summary>
        [Key(1)]
        public IEnumerable<ProductModelAvailabilityDayTime>? DayTimesAvailable { get; set; } = Enumerable.Empty<ProductModelAvailabilityDayTime>();

        #endregion
    }
}