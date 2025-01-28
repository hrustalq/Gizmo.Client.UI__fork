using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Popular product.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PopularProductModel : IPopularProductModel, IModelIntIdentifier
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Total purchases.
        /// </summary>
        [MessagePack.Key(1)]
        public int TotalPurchases { get; init; }
    }
}
