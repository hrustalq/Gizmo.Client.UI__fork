using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit transaction.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class DepositTransactionModel : IDepositTransactionModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The date that the deposit transaction was created.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The deposit balance of the user after this deposit transaction.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Balance { get; set; }

        /// <summary>
        /// The Id of the operator this deposit transaction is associated with.
        /// </summary>
        [MessagePack.Key(3)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this deposit transaction is associated with.
        /// </summary>
        [MessagePack.Key(4)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this deposit transaction is associated with.
        /// </summary>
        [MessagePack.Key(5)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The Id of the user this deposit transaction is associated with.
        /// </summary>
        [MessagePack.Key(6)]
        public int UserId { get; set; }

        /// <summary>
        /// The type of the deposit transaction.
        /// </summary>
        [MessagePack.Key(7)]
        [EnumValueValidation]
        public DepositTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the deposit transaction.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The Id of the payment method of this deposit transaction.
        /// </summary>
        [MessagePack.Key(9)]
        public int? PaymentMethodId { get; set; }

        #endregion
    }
}