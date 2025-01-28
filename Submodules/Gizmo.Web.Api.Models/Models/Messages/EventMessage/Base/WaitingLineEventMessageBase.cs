namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Waiting line", "WAITING_LINE_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Waiting line related events", "WAITING_LINE_EVENT_GROUP_DESCRIPTION")]
    [HideMetadata()]
    [EventGroup(4)]
    public abstract class WaitingLineEventMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WaitingLineEventMessageBase() : base()
        {
        }
        #endregion
    }
}
