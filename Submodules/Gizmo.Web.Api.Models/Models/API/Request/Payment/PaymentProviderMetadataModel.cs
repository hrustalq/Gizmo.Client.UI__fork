using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Provider metdata model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PaymentProviderMetadataModel
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new payment provider info instance.
        /// </summary>
        /// <param name="type">Type name.</param>
        /// <param name="name">Provider name.</param>
        /// <param name="guid">Provider guid.</param>
        public PaymentProviderMetadataModel(string type, string name, Guid guid)
        {
            Type = type;
            Name = name;
            Guid = guid;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets provider type.
        /// </summary>
        [Key(0)]
        public string Type { get; }

        /// <summary>
        /// Gets provider name.
        /// </summary>
        [Key(1)]
        public string Name { get; }

        /// <summary>
        /// Gets provider guid.
        /// </summary>
        [Key(2)]
        public Guid Guid { get; }

        /// <summary>
        /// Gets provider options type name.
        /// </summary>
        /// <remarks>
        /// This value might be null if payment provider does not have any options associated with it.
        /// </remarks>
        [Key(3)]
        public string? OptionsType { get; init; }

        /// <summary>
        /// Gets provider description.
        /// </summary>
        [Key(4)]
        public string? Description { get; init; }

        #endregion
    }
}
