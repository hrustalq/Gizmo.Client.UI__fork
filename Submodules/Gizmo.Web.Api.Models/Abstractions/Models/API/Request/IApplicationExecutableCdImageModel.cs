namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application executable cd image.
    /// </summary>
    public interface IApplicationExecutableCdImageModel : IWebApiModel
    {
        /// <summary>
        /// The path of the cd image.
        /// </summary>
        string? Path { get; set; }

        /// <summary>
        /// The mounting options of the cd image.
        /// </summary>
        string? MountOptions { get; set; }

        /// <summary>
        /// Whether the cd image will check the mounter process exit code value while mounting.
        /// </summary>
        bool CheckExitCode { get; set; }

        /// <summary>
        /// The device id of the cd image.
        /// </summary>
        string? DeviceId { get; set; }
    }
}