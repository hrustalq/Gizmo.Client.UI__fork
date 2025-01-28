using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductTime
    {
        #region PROPERTIES

        /// <summary>
        /// The number of minutes of the time product.
        /// </summary>
        [MessagePack.Key(0)]
        public int Minutes { get; set; }

        /// <summary>
        /// Whether the time product expires at logout.
        /// </summary>
        [MessagePack.Key(1)]
        public bool ExpiresAtLogout { get; set; }

        /// <summary>
        /// Whether the time product expires at a specific time in the day.
        /// </summary>
        [MessagePack.Key(2)]
        public bool ExpireAtDayTime { get; set; }

        /// <summary>
        /// The minute in the day at which the time product expires.
        /// </summary>
        [MessagePack.Key(3)]
        public int ExpireAtDayTimeMinute { get; set; }

        /// <summary>
        /// Whether the time product expires after a specific timespan.
        /// </summary>
        [MessagePack.Key(4)]
        public bool ExpireAfterTime { get; set; }

        /// <summary>
        /// The type of timespan after which the time product expires.
        /// </summary>
        [MessagePack.Key(5)]
        [EnumValueValidation]
        public ExpireAfterType ExpireAfterType { get; set; }

        /// <summary>
        /// The size of the timespan after which the time product expires.
        /// </summary>
        [MessagePack.Key(6)]
        public int ExpiresAfter { get; set; }

        /// <summary>
        /// The expire from options of the product.
        /// </summary>
        [MessagePack.Key(7)]
        [EnumValueValidation]
        public ExpireFromOptionType ExpiresFrom { get; set; }

        /// <summary>
        /// The order in which the product is used.
        /// </summary>
        [MessagePack.Key(8)]
        public int UseOrder { get; set; }

        #endregion
    }
}