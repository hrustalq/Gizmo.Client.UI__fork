using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User product group model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserProductGroupModel : IUserProductGroupModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the product group.
        /// </summary>
        [Key(1)]
        public string Name { get; set; } = null!;

        /// <inheritdoc/>
        [Key(2)]
        public ProductSortOptionType SortOption { get; set; } = ProductSortOptionType.Default;

        /// <inheritdoc/>
        [Key(3)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}
