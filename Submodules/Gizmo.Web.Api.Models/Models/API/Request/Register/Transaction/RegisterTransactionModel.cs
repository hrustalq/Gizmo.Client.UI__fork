using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register transaction.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class RegisterTransactionModel : IRegisterTransactionModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The date that the register transaction was created.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the operator this register transaction is associated with.
        /// </summary>
        [MessagePack.Key(2)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this register transaction is associated with.
        /// </summary>
        [MessagePack.Key(3)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this register transaction is associated with.
        /// </summary>
        [MessagePack.Key(4)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The type of the register transaction.
        /// </summary>
        [MessagePack.Key(5)]
        [EnumValueValidation]
        public RegisterTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the register transaction.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The note of the register transaction.
        /// </summary>
        [MessagePack.Key(7)]
        public string? Note { get; set; }

        #endregion
    }
}