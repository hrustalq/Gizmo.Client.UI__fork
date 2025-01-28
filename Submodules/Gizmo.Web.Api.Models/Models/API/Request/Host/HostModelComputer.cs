using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host computer.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class HostModelComputer
    {
        #region PROPERTIES

        /// <summary>
        /// The windows name of the computer.
        /// </summary>
        [MessagePack.Key(0)]
        public string WindowsName { get; set; } = null!;

        /// <summary>
        /// The MAC Address of the computer.
        /// </summary>
        [MessagePack.Key(1)]
        [MacAddressValidation]
        public string MacAddress { get; set; } = null!;

        #endregion
    }
}
