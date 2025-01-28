namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Host icon.
    /// </summary>
    public interface IHostIconModel : IWebApiModel
    {
        /// <summary>
        /// The image data of the host icon.
        /// </summary>
        byte[] Image { get; set; }
    }
}