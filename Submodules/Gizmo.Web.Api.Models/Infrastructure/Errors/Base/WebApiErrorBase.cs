using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Web api error base class.
    /// </summary>
    /// <remarks>
    /// Serves as base class for polymorphic web api errors.
    /// </remarks>
    [Union(0,typeof(WebApiError))]
    [Union(1, typeof(WebApiValidationError))]
    [Union(2, typeof(WebApiValidationErrors))]
    public abstract class WebApiErrorBase
    {
    }
}
