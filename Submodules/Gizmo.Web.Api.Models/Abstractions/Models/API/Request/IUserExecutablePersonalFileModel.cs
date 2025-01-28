namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User executable personal file model.
    /// </summary>
    public interface IUserExecutablePersonalFileModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets personal user file id.
        /// </summary>
        int PersonalFileId { get; init; }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        int UseOrder { get; init; }
    }
}
