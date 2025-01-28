namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application executable personal file.
    /// </summary>
    public interface IApplicationExecutablePersonalFileModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the personal file associated with this application executable.
        /// </summary>
        int PersonalFileId { get; set; }

        /// <summary>
        /// The order in which the personal file is used.
        /// </summary>
        int UseOrder { get; set; }
    }
}