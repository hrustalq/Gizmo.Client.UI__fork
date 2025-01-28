using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Web api validation errors model.
    /// </summary>
    /// <remarks>
    /// Provides single property / multiple error message.
    /// </remarks>
    [MessagePackObject()]
    public sealed class WebApiValidationErrors : WebApiErrorBase
    {
        #region PROPERTIES

        /// <summary>
        /// Error key.
        /// </summary>
        [Key(0)]
        public string? PropertyName
        {
            get; init;
        }

        /// <summary>
        /// Error values.
        /// </summary>
        [Key(1)]
        public string[]? Messages
        {
            get; init;
        } 

        #endregion
    }
}
