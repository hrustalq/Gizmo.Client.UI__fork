using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment method.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PaymentMethodModelUpdate : IPaymentMethodModel, IModelIntIdentifier, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the payment method.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The display order of the payment method.
        /// </summary>
        [MessagePack.Key(2)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the payment method is enabled.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Whether the payment method can be used by manager.
        /// </summary>
        [MessagePack.Key(4)]
        public bool AvailableInManager { get; set; }

        /// <summary>
        /// Whether the payment method can be used by clients.
        /// </summary>
        [MessagePack.Key(5)]
        public bool AvailableInClient { get; set; }

        /// <summary>
        /// Whether the payment method is deleted.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsDeleted { get; set; }

        #endregion
    }
}