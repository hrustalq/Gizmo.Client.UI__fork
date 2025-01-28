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
    public sealed class PaymentMethodModelCreate : IPaymentMethodModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the payment method.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The display order of the payment method.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the payment method is enabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Whether the payment method can be used by manager.
        /// </summary>
        [MessagePack.Key(3)]
        public bool AvailableInManager { get; set; }

        /// <summary>
        /// Whether the payment method can be used by clients.
        /// </summary>
        [MessagePack.Key(4)]
        public bool AvailableInClient { get; set; }

        /// <summary>
        /// Whether the payment method is deleted.
        /// </summary>
        [MessagePack.Key(5)]
        public bool IsDeleted { get; set; }

        #endregion
    }
}