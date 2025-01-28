using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundled product user price.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductBundledUserPriceModelCreate : IProductBundledUserPriceModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user group this user price is associated with.
        /// </summary>
        [Key(0)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The price for this user price.
        /// </summary>
        [Key(1)]
        public decimal? Price { get; set; }

        #endregion
    }
}