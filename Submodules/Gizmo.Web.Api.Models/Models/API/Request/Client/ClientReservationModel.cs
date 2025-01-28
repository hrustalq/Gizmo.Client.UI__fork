using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc/>
    [Serializable, MessagePackObject]
    public sealed class ClientReservationModel : IClientReservationModel
    {
        /// <inheritdoc/>
        [Key(0)]
        public int? NextReservationId { get; init; }

        /// <inheritdoc/>
        [Key(1)]
        public DateTime? NextReservationTime { get; init; }

        /// <inheritdoc/>
        [Key(2)]
        public bool EnableLoginBlock { get; init; }

        /// <inheritdoc/>
        [Key(3)]
        public int LoginBlockTime { get; init; }

        /// <inheritdoc/>
        [Key(4)]
        public bool EnableLoginUnblock { get; init; }

        /// <inheritdoc/>
        [Key(5)]
        public int LoginUnblockTime { get; init; }
    }
}
