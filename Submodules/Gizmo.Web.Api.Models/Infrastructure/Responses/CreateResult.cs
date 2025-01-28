using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Create result.
    /// </summary>
    [Serializable, MessagePackObject]
    public class CreateResult
    {
        #region PROPERTIES
        
        /// <summary>
        /// The Id of the newly created object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; } 

        #endregion
    }
}
