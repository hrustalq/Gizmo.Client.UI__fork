using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for popular applications.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PopularApplicationsFilter
    {
        #region FIELDS

        private const int DefaultLimit = 10;
        private int _limit = DefaultLimit;

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Limit records for the response.
        ///  equal 0 => DefaultLimit;
        ///  equal -1 => int.MaxValue;
        ///  less then -1 => DefaultLimit;
        ///  Default limit is 10.
        /// </summary>
        [Key(0)]
        public int Limit
        {
            get
            {
                return _limit;
            }
            set
            {
                _limit = value switch
                {
                    < -1 => DefaultLimit,
                    -1 => int.MaxValue - 1,
                    0 => DefaultLimit,
                    int.MaxValue => int.MaxValue - 1,
                    _ => value
                };
            }
        }

        /// <summary>
        /// Return popular applications for the specified user.
        /// </summary>
        [Key(1)]
        public int? UserId { get; set; }

        /// <summary>
        /// Return popular applications since the specified date.
        /// </summary>
        [Key(2)]
        public DateTime? DateFrom { get; set; }

        #endregion
    }
}
