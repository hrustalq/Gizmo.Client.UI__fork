using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User usage session event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserUsageSessionChangedEventArgs : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserUsageSessionChangedEventArgs() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets current time poroduct name.
        /// </summary>
        [Key(2)]
        public string CurrentTimeProduct
        {
            get; init;
        }

        /// <summary>
        /// Gets current usage type.
        /// </summary>
        [Key(3)]
        public UsageType CurrentUsageType
        {
            get; init;
        }

        #endregion
    }
}
