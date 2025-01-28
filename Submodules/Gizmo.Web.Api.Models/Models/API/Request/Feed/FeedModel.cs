using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc/>
    [Serializable, MessagePackObject]
    public sealed class FeedModel : IFeedModel
    {
        /// <inheritdoc/>
        [Key(0)]
        public string Title { get; init; }

        /// <inheritdoc/>
        [Key(1)]
        public int Maximum { get; init; }

        /// <inheritdoc/>
        [Key(2)]
        public string Url { get; init; }

        /// <inheritdoc/>
        [Key(3)]
        public int Id { get; init; }
    }
}
