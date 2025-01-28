using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User usage session model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageSessionModel : IUserUsageSessionModel
    {
        /// <inheritdoc/>
        [Key(0)]
        public int UsageSessionId { get; init; }

        /// <inheritdoc/>
        [Key(1)]
        public int UserId { get; init; }

        /// <inheritdoc/>
        [Key(2)]
        public string TimePorduct { get; init; }

        /// <inheritdoc/>
        [Key(3)]
        public UsageType CurrentUsageType { get; init; }
    }
}
