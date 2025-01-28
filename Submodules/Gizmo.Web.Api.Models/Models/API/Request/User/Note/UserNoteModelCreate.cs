using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User note.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserNoteModelCreate : IUserNoteModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The text of the note.
        /// </summary>
        [StringLength(65535)]
        [MessagePack.Key(0)]
        public string Text { get; set; } = null!;

        /// <summary>
        /// The severity of the note.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public NoteSeverity Severity { get; set; }

        #endregion
    }
}
