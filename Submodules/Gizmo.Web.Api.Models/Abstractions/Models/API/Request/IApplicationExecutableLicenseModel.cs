namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application executable license.
    /// </summary>
    public interface IApplicationExecutableLicenseModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the license associated with this application executable.
        /// </summary>
        int LicenseId { get; set; }

        /// <summary>
        /// The order in which the license is used.
        /// </summary>
        int UseOrder { get; set; }
    }
}