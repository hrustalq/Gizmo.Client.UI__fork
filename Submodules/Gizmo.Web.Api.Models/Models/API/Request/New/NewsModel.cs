using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc/>
    [Serializable, MessagePackObject]
    public sealed class NewsModel : INewsModel
    {
        /// <inheritdoc/>
        [Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [Key(1)]
        public bool IsCustomTemplate { get; init; }

        /// <inheritdoc/>
        [Key(2)]
        public string? Title { get; init; }

        /// <inheritdoc/>
        [Key(3)]
        public string Data { get; init; } = null!;

        /// <inheritdoc/>
        [Key(4)]
        public DateTime? StartDate { get; init; }

        /// <inheritdoc/>
        [Key(5)]
        public DateTime? EndDate { get; init; }

        /// <inheritdoc/>
        [Key(6)]
        public string? Url { get; init; }

        /// <inheritdoc/>
        [Key(7)]
        public string? MediaUrl { get; init; }

        /// <inheritdoc/>
        [Key(8)]
        public string? ThumbnailUrl { get; init; }
    }
}
