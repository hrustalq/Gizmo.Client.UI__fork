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
    public sealed class UserProfileModelCreate : IUserProfileModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The username of the user.
        /// </summary>
        [StringLength(30)]
        [MessagePack.Key(0)]
        public string Username { get; set; } = null!;

        /// <summary>
        /// The email of the user.
        /// </summary>
        [StringLength(254)]
        [EmailNullEmptyValidation]
        [MessagePack.Key(1)]
        public string? Email { get; set; }

        /// <summary>
        /// The first name of the user.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(2)]
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(3)]
        public string? LastName { get; set; }

        /// <summary>
        /// The birth date of the user.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The address of the user.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(5)]
        public string? Address { get; set; }

        /// <summary>
        /// The city of the user.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(6)]
        public string? City { get; set; }

        /// <summary>
        /// The country of the user.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(7)]
        public string? Country { get; set; }

        /// <summary>
        /// The post code of the user.
        /// </summary>
        [StringLength(20)]
        [MessagePack.Key(8)]
        public string? PostCode { get; set; }

        /// <summary>
        /// The phone number of the user.
        /// </summary>
        [StringLength(20)]
        [MessagePack.Key(9)]
        public string? Phone { get; set; }

        /// <summary>
        /// The mobile phone number of the user.
        /// </summary>
        [StringLength(20)]
        [MessagePack.Key(10)]
        public string? MobilePhone { get; set; }

        /// <summary>
        /// The sex of the user.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(11)]
        public Sex Sex { get; set; }

        #endregion
    }
}
