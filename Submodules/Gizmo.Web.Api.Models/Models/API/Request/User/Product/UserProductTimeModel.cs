using System;
using System.Collections.Generic;
using System.Linq;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User product time model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserProductTimeModel
    {
        /// <summary>
        /// The number of minutes of the time product.
        /// </summary>
        [Key(0)]
        public int Minutes { get; set; }

        /// <summary>
        /// The usage availability of the time product.
        /// </summary>
        [Key(1)]
        public ProductTimeUsageAvailabilityModel? UsageAvailability { get; set; }

        /// <summary>
        /// The list of disallowed host groups.
        /// </summary>
        [Key(2)]
        public IEnumerable<int> DisallowedHostGroups { get; set; } = Enumerable.Empty<int>();

        /// <summary>
        /// Gets or sets expire after days.
        /// </summary>
        [Key(3)]
        public int ExpiresAfter { get; set; }

        /// <summary>
        /// Gets or sets expiration options.
        /// </summary>
        [Key(4)]
        public ProductTimeExpirationOptionType ExpirationOptions { get; set; }

        /// <summary>
        /// Gets or sets expire from options.
        /// </summary>
        [Key(5)]
        public ExpireFromOptionType ExpireFromOptions { get; set; }

        /// <summary>
        /// Gets or sets expire after type.
        /// </summary>
        [Key(6)]
        public ExpireAfterType ExpireAfterType { get; set; }

        /// <summary>
        /// Gets or sets expire at day time minute.
        /// </summary>
        [Key(7)]
        public int ExpireAtDayTimeMinute { get; set; }

        /// <summary>
        /// Whether the product is restricted for current host group.
        /// </summary>
        [Key(8)]
        public bool IsRestrictedForHostGroup { get; set; }
    }
}
