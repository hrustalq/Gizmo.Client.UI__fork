using MessagePack;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Represents web api validation error with property name and description.
    /// </summary>
    /// <remarks>
    /// Provides single property / single error message.
    /// </remarks>
    [MessagePackObject()]
    public class WebApiValidationError : WebApiError
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        /// <param name="errorMessage">Validation error message.</param>
        public WebApiValidationError(string propertyName, string errorMessage) : base(errorMessage)
        {
            PropertyName = propertyName;
        }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Property name.
        /// </summary>
        [Key(1)]
        [JsonPropertyOrder(0)]
        public string PropertyName
        {
            get; protected set;
        }
        #endregion
    }
}
