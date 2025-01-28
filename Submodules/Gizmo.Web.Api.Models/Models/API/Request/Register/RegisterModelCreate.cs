using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class RegisterModelCreate : IRegisterModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The number of the register.
        /// </summary>
        [MessagePack.Key(0)]
        public int Number { get; set; }

        /// <summary>
        /// The name of the register.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The MAC address of the register.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(255)]
        [MacAddressValidation]
        public string? MacAddress { get; set; }

        /// <summary>
        /// The start cash of the register.
        /// </summary>
        [MessagePack.Key(3)]
        [Range(0.0, 1_000_000_000_000)]
        public decimal StartCash { get; set; }

        /// <summary>
        /// The idle timeout of the register.
        /// </summary>
        [MessagePack.Key(4)]
        public int? IdleTimeout { get; set; }

        #endregion
    }
}
