using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Popular executable.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PopularApplicationModel : IPopularApplicationModel, IModelIntIdentifier
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Total execution time.
        /// </summary>
        [MessagePack.Key(1)]
        public double TotalExecutionTime { get; init; }
    }
}
