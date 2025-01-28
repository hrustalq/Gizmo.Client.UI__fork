using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User payment method model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserPaymentMethodModel : IUserPaymentMethodModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the payment method.
        /// </summary>
        [Key(1)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// The display order of the payment method.
        /// </summary>
        [Key(2)]
        public int DisplayOrder { get; init; }

        /// <summary>
        /// Payment method is online.
        /// </summary>
        [Key(3)]
        public bool IsOnline { get; init; }

        #endregion
    }
}
