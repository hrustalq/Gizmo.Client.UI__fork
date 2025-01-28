using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Messaging.Models
{
    /// <summary>
    /// Event metadata.
    /// </summary>
    public sealed class EventMetadata
    {
        #region PROPERTIES

        /// <summary>
        /// Event name.
        /// </summary>
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Event description.
        /// </summary>
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Object type.
        /// </summary>
        [JsonIgnore()]
        public string Type { get; init; } = string.Empty;

        /// <summary>
        /// Event id used to identify the event.
        /// </summary>
        public int EventId { get; init; } = 0;

        #endregion
    }
}
