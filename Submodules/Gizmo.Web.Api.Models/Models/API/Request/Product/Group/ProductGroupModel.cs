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
    public sealed class ProductGroupModel : IProductGroupModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The GUID of the product group.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The name of the product group.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The display order of the product group.
        /// </summary>
        [MessagePack.Key(3)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The sort option of the product group.
        /// </summary>
        [MessagePack.Key(4)]
        [EnumValueValidation]
        public ProductSortOptionType SortOption { get; set; }

        #endregion
    }
}