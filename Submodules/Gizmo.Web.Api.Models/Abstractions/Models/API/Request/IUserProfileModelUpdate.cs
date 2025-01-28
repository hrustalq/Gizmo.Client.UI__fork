using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User profile.
    /// </summary>
    public interface IUserProfileModelUpdate : IWebApiModel
    {
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
        /// The sex of the user.
        /// </summary>
        Sex Sex { get; set; }

        /// <summary>
        /// The country of the user.
        /// </summary>
        string? Country { get; set; }
    }
}
