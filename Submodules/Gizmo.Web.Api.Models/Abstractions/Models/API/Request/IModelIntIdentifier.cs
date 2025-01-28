namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Interface of identifier as int for the api model
    /// </summary>
    public interface IModelIntIdentifier
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        int Id { get; init; }
    }
}