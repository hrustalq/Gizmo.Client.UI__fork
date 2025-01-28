using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User application category model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserApplicationCategoryModel : IUserApplicationCategoryModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the parent application category.
        /// </summary>
        [Key(1)]
        public int? ParentId { get; set; }

        /// <summary>
        /// The name of the application category.
        /// </summary>
        [Key(2)]
        public string Name { get; set; } = null!;

        #endregion
    }
}
