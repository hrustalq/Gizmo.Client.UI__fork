using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User profile.
    /// </summary>
    public interface IUserProfileModel : IWebApiModel
    {
        /// <summary>
        /// The username of the user.
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// The email of the user.
        /// </summary>
        string? Email { get; set; }

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
    }
}
