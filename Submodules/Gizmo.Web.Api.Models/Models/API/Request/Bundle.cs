using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundle.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class Bundle
    {
        #region PROPERTIES

        /// <summary>
        /// The stock options of the bundle.
        /// </summary>
        [Key(0)]
        public bool SelfStock { get; set; }

        #endregion
    }
}