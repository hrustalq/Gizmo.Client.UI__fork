using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by token result model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class AccountCreationCompleteResultModelByToken : IResultModelCode<AccountCreationByTokenCompleteResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Verification result code.
        /// </summary>
        [Key(0)]
        [JsonPropertyOrder(0)]
        public AccountCreationByTokenCompleteResultCode Result { get; set; }

        /// <summary>
        /// Newly created user id.
        /// </summary>
        [Key(1)]
        [JsonPropertyOrder(1)]
        public int? CreatedUserId { get; set; }

        #endregion
    }
}
