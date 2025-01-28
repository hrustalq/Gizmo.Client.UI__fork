using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Operator.
    /// </summary>
    public interface IOperatorModel : IWebApiModel
    {
        #region UsersOperator

        /// <summary>
        /// The username of the operator.
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// The email of the operator.
        /// </summary>
        string? Email { get; set; }

        #endregion

        #region User

        /// <summary>
        /// The address of the operator.
        /// </summary>
        string? Address { get; set; }

        /// <summary>
        /// The birth date of the operator.
        /// </summary>
        DateTime? BirthDate { get; set; }

        /// <summary>
        /// The city of the operator.
        /// </summary>
        string? City { get; set; }

        /// <summary>
        /// The country of the operator.
        /// </summary>
        string? Country { get; set; }

        /// <summary>
        /// The first name of the operator.
        /// </summary>
        string? FirstName { get; set; }

        /// <summary>
        /// The identification number of the operator.
        /// </summary>
        string Identification { get; set; }

        /// <summary>
        /// Whether the operator is disabled.
        /// </summary>
        bool IsDeleted { get; set; }

        /// <summary>
        /// Whether the operator is deleted.
        /// </summary>
        bool IsDisabled { get; set; }

        /// <summary>
        /// The last name of the operator.
        /// </summary>
        string? LastName { get; set; }

        /// <summary>
        /// The mobile phone number of the operator.
        /// </summary>
        string? MobilePhone { get; set; }

        /// <summary>
        /// The phone number of the operator.
        /// </summary>
        string? Phone { get; set; }

        /// <summary>
        /// The post code of the operator.
        /// </summary>
        string? PostCode { get; set; }

        /// <summary>
        /// The sex of the operator.
        /// </summary>
        Sex Sex { get; set; }

        /// <summary>
        /// The SmartCard UID of the operator.
        /// </summary>
        string? SmartCardUid { get; set; }

        #endregion
    }
}