using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Host", "HOST_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host related events", "HOST_EVENT_GROUP_DESCRIPTION")]
    [HideMetadata()]
    [EventGroup(8)]
    public abstract class HostEventMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostEventMessageBase() : base()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets host id.
        /// </summary>
        [Key(1)]
        public int HostId
        {
            get; init;
        } 

        #endregion
    }
}
