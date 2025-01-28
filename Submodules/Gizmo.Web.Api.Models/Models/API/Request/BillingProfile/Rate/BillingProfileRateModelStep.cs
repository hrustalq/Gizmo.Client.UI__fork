using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate step.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class BillingProfileRateModelStep
    {
        #region PROPERTIES

        /// <summary>
        /// The minute of the rate step.
        /// </summary>
        [MessagePack.Key(0)]
        public int Minute { get; set; }

        /// <summary>
        /// The action of the rate step.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public BillingRateStepAction Action { get; set; }

        /// <summary>
        /// The charge value of the rate step.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Charge { get; set; }

        /// <summary>
        /// The rate value of the rate step.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Rate { get; set; }

        /// <summary>
        /// The target minute of the rate step.
        /// </summary>
        [MessagePack.Key(4)]
        public int TargetMinute { get; set; }

        #endregion
    }
}