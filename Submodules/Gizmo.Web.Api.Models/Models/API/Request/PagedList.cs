using System;
using System.Collections.Generic;
using System.Linq;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Model for the paginated data.
    /// </summary>
    /// <typeparam name="T">Data type.</typeparam>
    [Serializable, MessagePackObject]
    public sealed class PagedList<T>
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="data">Data.</param>
        public PagedList(IEnumerable<T> data)
        {
            Data = data;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// The data of the current result set.
        /// </summary>
        [Key(0)]
        public IEnumerable<T> Data { get; } = Enumerable.Empty<T>();

        /// <summary>
        /// Cursor for the request of the next chunk of the records.
        /// </summary>
        [Key(1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(CursorBase64Converter))]
        public PaginationCursor? NextCursor { get; set; }

        /// <summary>
        /// Cursor for the request of the previous chunk of the records.
        /// </summary>
        [Key(2)]
        [System.Text.Json.Serialization.JsonConverter(typeof(CursorBase64Converter))]
        public PaginationCursor? PrevCursor { get; set; }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Set cursor for the next request.
        /// </summary>
        /// <param name="pagination">Pagination model.</param>
        public void SetCursor(ModelFilterPagination pagination)
        {
            if (pagination.Cursor is not null)
            {
                if (pagination.Cursor.IsForward)
                {
                    if (NextCursor is null)
                        NextCursor = pagination.Cursor;
                    else
                        pagination.Cursor = NextCursor;
                }
                else
                {
                    if (PrevCursor is null)
                        PrevCursor = pagination.Cursor;
                    else
                        pagination.Cursor = PrevCursor;
                }
            }
            else
            {
                pagination.Cursor = NextCursor;
            }
        }

        #endregion
    }
}
