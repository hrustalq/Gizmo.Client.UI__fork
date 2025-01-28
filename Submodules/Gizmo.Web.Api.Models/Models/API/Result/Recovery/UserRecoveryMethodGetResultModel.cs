using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User recovery method get result.
    /// </summary>
    /// <remarks>
    /// Default <see cref="IResultModelCode{T}.Result"/> code value is <see cref="UserRecoverMethodGetResultCode.Success"/>.
    /// </remarks>
    [Serializable, MessagePackObject]
    public sealed class UserRecoveryMethodGetResultModel : IResultModelCode<UserRecoverMethodGetResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Verification result code.
        /// </summary>
        [Key(0)]
        [JsonPropertyOrder(0)]
        public UserRecoverMethodGetResultCode Result { get; set; }

        /// <summary>
        /// Gets available recovery method.
        /// </summary>
        /// <remarks>
        /// Default value <see cref="UserRecoveryMethod.None"/>.
        /// </remarks>
        [Key(1)]
        [JsonPropertyOrder(1)]
        public UserRecoveryMethod RecoveryMethod { get; init; } = UserRecoveryMethod.None;

        #endregion
    }
}
