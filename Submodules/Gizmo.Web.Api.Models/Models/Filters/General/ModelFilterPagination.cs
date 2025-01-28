using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Pagination model by cursor pagination.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ModelFilterPagination
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
            get => _limit;
            set => _limit = value switch
            {
                < -1 => DefaultLimit,
                -1 => int.MaxValue - 1,
                0 => DefaultLimit,
                int.MaxValue => int.MaxValue - 1,
                _ => value
            };
        }
        /// <summary>
        /// Sorting field name (column name) of the data.
        /// </summary>
        /// <value>
        /// Default value is "Id".
        /// </value>
        [Key(1)]
        public string SortBy { get; set; } = "Id";

        /// <summary>
        /// Sorting direction of the data.
        /// </summary>
        /// <value>
        /// true - for ascending, false - for descending.
        /// </value>
        [Key(2)]
        public bool IsAsc { get; set; } = true;

        /// <summary>
        /// Support infinite scrolling.
        /// </summary>
        /// <value>
        /// true - for infinite scrolling, false - for pagination.
        /// </value>
        [Key(3)]
        public bool IsScroll { get; set; } = false;

        /// <summary>
        /// Cursor for the request.
        /// </summary>
        [Key(4)]
        [System.Text.Json.Serialization.JsonConverter(typeof(CursorBase64Converter))]
        public PaginationCursor? Cursor { get; set; }

        #endregion
    }
}
