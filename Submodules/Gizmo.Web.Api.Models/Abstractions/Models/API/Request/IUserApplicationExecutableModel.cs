using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User application executable model.
    /// </summary>
    public interface IUserApplicationExecutableModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the application this executable belongs to.
        /// </summary>
        int ApplicationId { get; set; }

        /// <summary>
        /// The caption of the executable.
        /// </summary>
        string? Caption { get; set; }

        /// <summary>
        /// The description of the executable.
        /// </summary>
        string? Description { get; set; }

        /// <summary>
        /// The display order of the executable.
        /// </summary>
        int DisplayOrder { get; set; }

        /// <summary>
        /// The personal files of this executable.
        /// </summary>
        IEnumerable<UserExecutablePersonalFileModel> PersonalFiles { get; set; }

        /// <summary>
        /// The Id of the executable's image.
        /// </summary>
        int? ImageId { get; set; }

        /// <summary>
        /// The executable options.
        /// </summary>
        ExecutableOptionType Options { get; set; }
    }
}
