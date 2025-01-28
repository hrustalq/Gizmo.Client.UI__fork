using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host endpoint.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class HostModelEndpoint
    {
        #region PROPERTIES

        /// <summary>
        /// The maximum number of users the endpoint can host.
        /// </summary>
        [Key(0)]
        public int MaximumUsers { get; set; }

        #endregion
    }
}
