using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User verification state info model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserModelVerificationState
    {
        #region PROPERTIES

        /// <summary>
        /// Indicates if verification was previously completed.
        /// </summary>
        [Key(0)]
        public bool IsVerified { get; init; }

        /// <summary>
        /// Indicates if verification is currently pending.
        /// </summary>
        [Key(1)]
        public bool IsVerificationPending { get; init; }

        /// <summary>
        /// Indicates if verification was initiated but expired.
        /// </summary>
        [Key(2)]
        public bool IsVerificationExpired { get; init; }

        /// <summary>
        /// Indicates if value is assigned to a user.
        /// </summary>
        [Key(3)]
        public bool IsAssigned { get; init; }

        #endregion
    }
}
