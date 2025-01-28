using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Required user info.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserModelRequiredInfo
    {
        #region PROPERTIES

        /// <summary>
        /// Whether the first name of the user is required.
        /// </summary>
        [Key(0)]
        public bool FirstName { get; set; }

        /// <summary>
        /// Whether the last name of the user is required.
        /// </summary>
        [Key(1)]
        public bool LastName { get; set; }

        /// <summary>
        /// Whether the birth date of the user is required.
        /// </summary>
        [Key(2)]
        public bool BirthDate { get; set; }

        /// <summary>
        /// Whether the address of the user is required.
        /// </summary>
        [Key(3)]
        public bool Address { get; set; }

        /// <summary>
        /// Whether the city of the user is required.
        /// </summary>
        [Key(4)]
        public bool City { get; set; }

        /// <summary>
        /// Whether the post code of the user is required.
        /// </summary>
        [Key(5)]
        public bool PostCode { get; set; }

        /// <summary>
        /// Whether the state of the user is required.
        /// </summary>
        [Key(6)]
        public bool State { get; set; }

        /// <summary>
        /// Whether the country of the user is required.
        /// </summary>
        [Key(7)]
        public bool Country { get; set; }

        /// <summary>
        /// Whether the e-mail of the user is required.
        /// </summary>
        [Key(8)]
        public bool Email { get; set; }

        /// <summary>
        /// Whether the phone of the user is required.
        /// </summary>
        [Key(9)]
        public bool Phone { get; set; }

        /// <summary>
        /// Whether the mobile phone of the user is required.
        /// </summary>
        [Key(10)]
        public bool Mobile { get; set; }

        /// <summary>
        /// Whether the sex of the user is required.
        /// </summary>
        [Key(11)]
        public bool Sex { get; set; }

        /// <summary>
        /// Whether a password for the user is required.
        /// </summary>
        [Key(12)]
        public bool Password { get; set; }

        #endregion
    }
}