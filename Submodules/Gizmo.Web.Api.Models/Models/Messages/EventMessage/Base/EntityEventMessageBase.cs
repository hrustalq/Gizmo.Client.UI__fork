namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Entity event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Entity","ENTITY_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Entity related events", "ENTITY_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(1)]
    public abstract class EntityEventMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public EntityEventMessageBase() : base()
        { }

        #endregion
    }
}
