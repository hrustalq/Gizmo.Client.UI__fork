using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Get result.
    /// </summary>
    [Serializable, MessagePackObject]
    public class GetResult<T>
    {
        #region PROPERTIES

        /// <summary>
        /// The value.
        /// </summary>
        [Key(0)]
        public T? Value { get; set; }

        #endregion
    }
}
