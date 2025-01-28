using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User.
    /// </summary>
    public interface IUserModel : IWebApiModel
    {
        #region UserMember

        /// <summary>
        /// The username of the user.
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// The email of the user.
        /// </summary>
        string? Email { get; set; }

        /// <summary>
        /// The Id of the users group id this user belongs to.
        /// </summary>
        int UserGroupId { get; set; }

        /// <summary>
        /// Whether the user is allowed to have negative balance.
        /// </summary>
        bool? IsNegativeBalanceAllowed { get; set; }

        /// <summary>
        /// Whether the personal info has been requested from the user.
        /// </summary>
        bool IsPersonalInfoRequested { get; set; }

        /// <summary>
        /// The date the user will be enabled again.
        /// </summary>
        DateTime? EnableDate { get; set; }

        /// <summary>
        /// The date the user has been disabled.
        /// </summary>
        DateTime? DisabledDate { get; set; }

        #endregion

        #region User

        /// <summary>
        /// The first name of the user.
        /// </summary>
        string? FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        string? LastName { get; set; }

        /// <summary>
        /// The birth date of the user.
        /// </summary>
        DateTime? BirthDate { get; set; }

        /// <summary>
        /// The address of the user.
        /// </summary>
        string? Address { get; set; }

        /// <summary>
        /// The city of the user.
        /// </summary>
        string? City { get; set; }

        /// <summary>
        /// The country of the user.
        /// </summary>
        string? Country { get; set; }

        /// <summary>
        /// The post code of the user.
        /// </summary>
        string? PostCode { get; set; }

        /// <summary>
        /// The phone number of the user.
        /// </summary>
        string? Phone { get; set; }

        /// <summary>
        /// The mobile phone number of the user.
        /// </summary>
        string? MobilePhone { get; set; }

        /// <summary>
        /// The sex of the user.
        /// </summary>
        Sex Sex { get; set; }

        /// <summary>
        /// Whether the user is deleted.
        /// </summary>
        bool IsDeleted { get; set; }

        /// <summary>
        /// Whether the user is disabled.
        /// </summary>
        bool IsDisabled { get; set; }

        /// <summary>
        /// The SmartCard UID of the user.
        /// </summary>
        string? SmartCardUid { get; set; }

        /// <summary>
        /// The identification number of the user.
        /// </summary>
        string? Identification { get; set; }

        #endregion
    }
}