using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserModelCreate : IUserModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The initial password for the user, if left empty no password will be set.
        /// </summary>
        [StringLength(24)]
        [MessagePack.Key(0)]
        public string? Password { get; set; }

        #region UserMember

        /// <summary>
        /// The username of the user.
        /// </summary>
        [StringLength(30)]
        [MessagePack.Key(1)]
        public string Username { get; set; } = null!;

        /// <summary>
        /// The email of the user.
        /// </summary>
        [StringLength(254)]
        [EmailNullEmptyValidation]
        [MessagePack.Key(2)]
        public string? Email { get; set; }

        /// <summary>
        /// The Id of the users group id this user belongs to.
        /// </summary>
        [MessagePack.Key(3)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// Whether the user is allowed to have negative balance.
        /// </summary>
        [MessagePack.Key(4)]
        public bool? IsNegativeBalanceAllowed { get; set; }

        /// <summary>
        /// Whether the personal info has been requested from the user.
        /// </summary>
        [MessagePack.Key(5)]
        public bool IsPersonalInfoRequested { get; set; }

        /// <summary>
        /// The date the user will be enabled again.
        /// </summary>
        [MessagePack.Key(6)]
        public DateTime? EnableDate { get; set; }

        /// <summary>
        /// The date the user has been disabled.
        /// </summary>
        [MessagePack.Key(7)]
        public DateTime? DisabledDate { get; set; }

        #endregion

        #region User

        /// <summary>
        /// The first name of the user.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(8)]
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(9)]
        public string? LastName { get; set; }

        /// <summary>
        /// The birth date of the user.
        /// </summary>
        [MessagePack.Key(10)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The address of the user.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(11)]
        public string? Address { get; set; }

        /// <summary>
        /// The city of the user.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(12)]
        public string? City { get; set; }

        /// <summary>
        /// The country of the user.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(13)]
        public string? Country { get; set; }

        /// <summary>
        /// The post code of the user.
        /// </summary>
        [StringLength(20)]
        [MessagePack.Key(14)]
        public string? PostCode { get; set; }

        /// <summary>
        /// The phone number of the user.
        /// </summary>
        [StringLength(20)]
        [MessagePack.Key(15)]
        public string? Phone { get; set; }

        /// <summary>
        /// The mobile phone number of the user.
        /// </summary>
        [StringLength(20)]
        [MessagePack.Key(16)]
        public string? MobilePhone { get; set; }

        /// <summary>
        /// The sex of the user.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(17)]
        public Sex Sex { get; set; }

        /// <summary>
        /// Whether the user is deleted.
        /// </summary>
        [MessagePack.Key(18)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Whether the user is disabled.
        /// </summary>
        [MessagePack.Key(19)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// The SmartCard UID of the user.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(12)]
        public string? SmartCardUid { get; set; }

        /// <summary>
        /// The identification number of the user.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(21)]
        public string? Identification { get; set; }

        #endregion

        #endregion
    }
}
