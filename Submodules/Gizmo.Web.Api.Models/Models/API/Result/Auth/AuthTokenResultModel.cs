using System.Text.Json.Serialization;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Authentication token result model.
    /// </summary>
    /// <remarks>
    /// This model is used for returing authentication and refresh tokens.
    /// </remarks>
    [MessagePackObject()]
    public sealed class AuthTokenResultModel
    {
        /// <summary>
        /// Token.
        /// </summary>
        [Key(0)]
        [JsonPropertyOrder(0)]
        public string Token
        {
            get; init;
        } = string.Empty;

        /// <summary>
        /// Refresh token.
        /// </summary>
        [Key(1)]
        [JsonPropertyOrder(1)]
        public string RefreshToken
        {
            get; init;
        } = string.Empty;
    }
}
