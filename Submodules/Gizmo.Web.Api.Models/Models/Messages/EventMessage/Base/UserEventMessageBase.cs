using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("User", "USER_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("User related events", "USER_EVENT_GROUP_DESCRIPTION")]   
    [HideMetadata()]
    [EventGroup(3)]
    public abstract class UserEventMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserEventMessageBase() : base()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets user id.
        /// </summary>
        [Key(1)]
        public int UserId
        {
            get; set;
        } 

        #endregion
    }
}
