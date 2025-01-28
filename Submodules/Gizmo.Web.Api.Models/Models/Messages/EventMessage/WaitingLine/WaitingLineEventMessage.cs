using MessagePack;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line event message.
    /// </summary>
    [MessagePackObject()]
    public sealed class WaitingLineEventMessage : WaitingLineEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WaitingLineEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets host group id.
        /// </summary>
        [Key(1)]
        public int? HostGroupId
        {
            get; init;
        }

        /// <summary>
        /// Gets affected lines.
        /// </summary>
        [Key(2)]
        public IEnumerable<WaitingLineStateModel> ActiveStates
        {
            get; init;
        } = Enumerable.Empty<WaitingLineStateModel>();

        #endregion
    }
}
