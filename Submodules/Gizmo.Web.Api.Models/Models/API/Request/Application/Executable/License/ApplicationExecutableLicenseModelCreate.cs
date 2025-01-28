using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable license.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationExecutableLicenseModelCreate : IApplicationExecutableLicenseModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the license associated with this application executable.
        /// </summary>
        [Key(0)]
        public int LicenseId { get; set; }

        /// <summary>
        /// The order in which the license is used.
        /// </summary>
        [Key(1)]
        public int UseOrder { get; set; }

        #endregion
    }
}
