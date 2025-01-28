#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application category.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationCategoryModelCreate : IApplicationCategoryModel
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the application category.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The Id of the parent category if the category is a subcategory, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(1)]
        public int? ParentId { get; set; }

        #endregion
    }
}
