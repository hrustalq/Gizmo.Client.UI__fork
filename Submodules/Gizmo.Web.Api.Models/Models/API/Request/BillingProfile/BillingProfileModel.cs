using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class BillingProfileModel : IBillingProfileModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the billing profile.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The default rate of the billing profile.
        /// </summary>
        [MessagePack.Key(2)]
        public BillingProfileRateModel? DefaultRate { get; set; }

        /// <summary>
        /// The rates of the billing profile.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<BillingProfileRateModel> Rates { get; set; } = Enumerable.Empty<BillingProfileRateModel>();

        #endregion
    }
}