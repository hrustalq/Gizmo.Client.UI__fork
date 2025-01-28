using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate day.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class BillingProfileRateModelDay
    {
        #region PROPERTIES

        /// <summary>
        /// The day of the week.
        /// </summary>
        [Key(0)]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// The timespans during which the rate is applicable for this day.
        /// </summary>
        [Key(1)]
        public IEnumerable<BillingProfileRateModelDayTime> DayTimesApplicable { get; set; } = Enumerable.Empty<BillingProfileRateModelDayTime>();

        #endregion
    }
}
