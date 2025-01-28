using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class OperatorModel : IOperatorModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The GUID of the operator.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid Guid { get; set; }

        #region UsersOperator

        /// <summary>
        /// The username of the operator.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(30)]
        public string Username { get; set; } = null!;

        /// <summary>
        /// The email of the operator.
        /// </summary>
        [MessagePack.Key(3)]
        [StringLength(254)]
        [EmailNullEmptyValidation]
        public string? Email { get; set; }

        #endregion

        #region User

        /// <summary>
        /// The first name of the operator.
        /// </summary>
        [MessagePack.Key(4)]
        [StringLength(45)]
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name of the operator.
        /// </summary>
        [MessagePack.Key(5)]
        [StringLength(45)]
        public string? LastName { get; set; }

        /// <summary>
        /// The birth date of the operator.
        /// </summary>
        [MessagePack.Key(6)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The address of the operator.
        /// </summary>
        [MessagePack.Key(7)]
        [StringLength(255)]
        public string? Address { get; set; }

        /// <summary>
        /// The city of the operator.
        /// </summary>
        [MessagePack.Key(8)]
        [StringLength(45)]
        public string? City { get; set; }

        /// <summary>
        /// The country of the operator.
        /// </summary>
        [MessagePack.Key(9)]
        [StringLength(45)]
        public string? Country { get; set; }

        /// <summary>
        /// The post code of the operator.
        /// </summary>
        [MessagePack.Key(10)]
        [StringLength(20)]
        public string? PostCode { get; set; }

        /// <summary>
        /// The phone number of the operator.
        /// </summary>
        [MessagePack.Key(11)]
        [StringLength(20)]
        public string? Phone { get; set; }

        /// <summary>
        /// The mobile phone number of the operator.
        /// </summary>
        [MessagePack.Key(12)]
        [StringLength(20)]
        public string? MobilePhone { get; set; }

        /// <summary>
        /// The sex of the operator.
        /// </summary>
        [MessagePack.Key(13)]
        [EnumValueValidation]
        public Sex Sex { get; set; }

        /// <summary>
        /// Whether the operator is deleted.
        /// </summary>
        [MessagePack.Key(14)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Whether the operator is disabled.
        /// </summary>
        [MessagePack.Key(15)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// The SmartCard UID of the operator.
        /// </summary>
        [MessagePack.Key(16)]
        [StringLength(255)]
        public string? SmartCardUid { get; set; }

        /// <summary>
        /// The identification number of the operator.
        /// </summary>
        [MessagePack.Key(17)]
        [StringLength(255)]
        public string Identification { get; set; } = null!;

        #endregion

        #endregion
    }
}
