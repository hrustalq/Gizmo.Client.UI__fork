namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Attribute.
    /// </summary>
    public interface IAttributeModel : IWebApiModel
    {
        /// <summary>
        /// The friendly name of the attribute.
        /// </summary>
        string? FriendlyName { get; set; }

        /// <summary>
        /// The name of the attribute.
        /// </summary>
        string Name { get; set; }
    }
}