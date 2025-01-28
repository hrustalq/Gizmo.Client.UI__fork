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
    public sealed class ProductGroupModelUpdate : IProductGroupModel, IModelIntIdentifier, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the product group.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The display order of the product group.
        /// </summary>
        [MessagePack.Key(2)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The sort option of the product group.
        /// </summary>
        [MessagePack.Key(3)]
        [EnumValueValidation]
        public ProductSortOptionType SortOption { get; set; }

        #endregion
    }
}