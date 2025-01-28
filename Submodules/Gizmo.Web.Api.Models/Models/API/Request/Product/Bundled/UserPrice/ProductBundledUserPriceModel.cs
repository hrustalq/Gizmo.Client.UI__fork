using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundled product user price.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductBundledUserPriceModel : IProductBundledUserPriceModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the bundled product this user price is associated with.
        /// </summary>
        [Key(1)]
        public int BundledProductId { get; set; }

        /// <summary>
        /// The Id of the user group this user price is associated with.
        /// </summary>
        [Key(2)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The price for this user price.
        /// </summary>
        [Key(3)]
        public decimal? Price { get; set; }

        #endregion
    }
}