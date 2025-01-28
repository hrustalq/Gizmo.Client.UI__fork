using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User agreement model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserAgreementModelCreate : IUserAgreementModel
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the user agreement.
        /// </summary>
        [Key(0)]
        public string? Name { get; set; }

        /// <summary>
        /// The user agreement text.
        /// </summary>
        [Key(1)]
        public string? Agreement { get; set; }

        /// <summary>
        /// The display order of the user agreement.
        /// </summary>
        [Key(2)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the user agreement is enabled.
        /// </summary>
        [Key(3)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Whether the user agreement is rejectable.
        /// </summary>
        [Key(4)]
        public bool IsRejectable { get; set; }

        /// <summary>
        /// Whether the user agreement should ignore state.
        /// </summary>
        [Key(5)]
        public bool IgnoreState { get; set; }

        #endregion
    }
}
