namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    public interface IDeviceHostModel : IWebApiModel
    {
        /// <summary>
        /// Gets device id.
        /// </summary>
        int DeviceId { get; set; }
    }
}