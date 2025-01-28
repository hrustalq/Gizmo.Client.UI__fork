using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Messaging.Models
{
    /// <summary>
    /// Event group metadata.
    /// </summary>
    public sealed class EventGroupMetadata
    {
        #region PROPERTIES

        /// <summary>
        /// Event group name.
        /// </summary>
        public string GroupName { get; init; } = string.Empty;

        /// <summary>
        /// Event group id.
        /// </summary>
        public int GroupId { get; init; }

        /// <summary>
        /// Event group description.
        /// </summary>
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Object type.
        /// </summary>
        [JsonIgnore()]
        public string Type { get;init;} =string.Empty;

        /// <summary>
        /// Events.
        /// </summary>
        public IEnumerable<EventMetadata> Events { get; init; } = Enumerable.Empty<EventMetadata>();

        #endregion
    }
}
