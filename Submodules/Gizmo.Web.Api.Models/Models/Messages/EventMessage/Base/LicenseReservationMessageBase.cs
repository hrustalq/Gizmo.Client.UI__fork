namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// License reservation message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("License", "LICENSE_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("License related events", "LICENSE_EVENT_GROUP_DESCRIPTION")]
    [HideMetadata()]
    [EventGroup(5)]
    public abstract class LicenseReservationMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public LicenseReservationMessageBase() : base()
        {
        } 
        #endregion
    }
}
