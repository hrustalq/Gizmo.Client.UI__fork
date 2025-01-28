using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User profile.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserProfileModelUpdate : IUserProfileModelUpdate, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The first name of the user.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(1)]
        public string? LastName { get; set; }

        /// <summary>
        /// The birth date of the user.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The sex of the user.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(3)]
        public Sex Sex { get; set; }

        /// <summary>
        /// The country of the user.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(4)]
        public string? Country { get; set; }

        #endregion
    }
}
