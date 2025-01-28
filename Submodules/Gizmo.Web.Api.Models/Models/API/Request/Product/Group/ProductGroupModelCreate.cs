using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductGroupModelCreate : IProductGroupModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the product group.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The display order of the product group.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The sort option of the product group.
        /// </summary>
        [MessagePack.Key(2)]
        [EnumValueValidation]
        public ProductSortOptionType SortOption { get; set; }

        #endregion
    }
}