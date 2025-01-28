using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Entity change event message.
    /// </summary>
    [MessagePackObject()]
    [System.ComponentModel.DataAnnotations.Name("Entity change", "ENTITY_CHANGE_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates an database entity chgange", "ENTITY_CHANGE_EVENT_DESCRIPTION")]
    public sealed class EntityChangeEventMessage : EntityEventMessageBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets entity id.
        /// </summary>
        [Key(1)]
        public int EntityId
        {
            get; set;
        }

        /// <summary>
        /// Gets event type.
        /// </summary>
        /// <remarks>
        /// This value identifies database operation such as create,delete,update etc.
        /// </remarks>
        [Key(2)]
        public EntityEventType EventType
        {
            get; set;
        }

        /// <summary>
        /// Gets entity type name.
        /// </summary>
        [Key(3)]
        public string? EntityType
        {
            get; set;
        }

        #endregion

        #region OVERRIDES

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Entity event type [{EventType}], Entity type [{EntityType}], Entity Id [{EntityId}]";
        } 

        #endregion
    }  
}
