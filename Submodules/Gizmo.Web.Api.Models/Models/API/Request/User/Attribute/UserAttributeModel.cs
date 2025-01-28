using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User attribute.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserAttributeModel : IUserAttributeModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the user this attribute belongs to.
        /// </summary>
        [MessagePack.Key(1)]
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the attribute this user attribute is associated with.
        /// </summary>
        [MessagePack.Key(2)]
        public int AttributeId { get; set; }

        /// <summary>
        /// The value of the user attribute.
        /// </summary>
        [MessagePack.Key(3)]
        [StringLength(255)]
        public string Value { get; set; } = null!;

        #endregion
    }
}
