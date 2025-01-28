using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task script.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationTaskModelScript
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the script.
        /// </summary>
        [MessagePack.Key(0)]
        [EnumValueValidation]
        public ScriptTypes ScriptType { get; set; }

        /// <summary>
        /// The data of the script.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(65535)]
        public string Data { get; set; } = null!;

        /// <summary>
        /// Whether the script is awaited until exit.
        /// </summary>
        [MessagePack.Key(2)]
        public bool Wait { get; set; }

        /// <summary>
        /// Whether the script is invisible.
        /// </summary>
        [MessagePack.Key(3)]
        public bool NoWindow { get; set; }

        #endregion
    }
}