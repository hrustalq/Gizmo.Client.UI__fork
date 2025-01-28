namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Image.
    /// </summary>
    public interface IImageModel : IWebApiModel
    {
        /// <summary>
        /// The image data.
        /// </summary>
        byte[] Image { get; set; }
    }
}