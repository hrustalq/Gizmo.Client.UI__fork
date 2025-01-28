using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate day time.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class BillingProfileRateModelDayTime
    {
        #region PROPERTIES

        /// <summary>
        /// The start second of this timespan.
        /// </summary>
        [Key(0)]
        public int StartSecond { get; set; }

        /// <summary>
        /// The end second of this timespan.
        /// </summary>
        [Key(1)]
        public int EndSecond { get; set; }

        #endregion
    }
}