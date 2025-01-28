using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class BillingProfileRateModel : IBillingProfileRateModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The start fee of the rate.
        /// </summary>
        [Key(1)]
        public decimal StartFee { get; set; }

        /// <summary>
        /// The minimum fee of the rate.
        /// </summary>
        [Key(2)]
        public decimal MinimumFee { get; set; }

        /// <summary>
        /// The hourly rate of the rate.
        /// </summary>
        [Key(3)]
        public decimal Rate { get; set; }

        /// <summary>
        /// The interval in minutes between the charges.
        /// </summary>
        [Key(4)]
        public int ChargeEvery { get; set; }

        /// <summary>
        /// The number of minutes before the first charge.
        /// </summary>
        [Key(5)]
        public int ChargeAfter { get; set; }

        /// <summary>
        /// Whether the rate is step based.
        /// </summary>
        [Key(6)]
        public bool IsStepBased { get; set; }

        /// <summary>
        /// The steps of the rate.
        /// </summary>
        [Key(7)]
        public IEnumerable<BillingProfileRateModelStep> RateSteps { get; set; } = Enumerable.Empty<BillingProfileRateModelStep>();

        /// <summary>
        /// The days on which the rate is applicable.
        /// </summary>
        [Key(8)]
        public IEnumerable<BillingProfileRateModelDay> Days { get; set; } = Enumerable.Empty<BillingProfileRateModelDay>();

        #endregion
    }
}