namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Interface for URI parameters.
    /// </summary>
    /// <remarks>
    /// We can use the interface to identified between different url parameter classes if required.
    /// </remarks>
    public interface IUriParameters
    {
        /// <summary>
        /// Query parameters from ModelFilter as string
        /// </summary>
        string? Query { get; }
        /// <summary>
        /// Path parameters from WebClient API as string
        /// </summary>
        string? Path { get; }
    }
}
