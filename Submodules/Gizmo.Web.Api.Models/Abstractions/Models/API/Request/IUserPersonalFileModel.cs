namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User personal file model.
    /// </summary>
    public interface IUserPersonalFileModel : IWebApiModel
    {
        /// <summary>
        /// The type of the personal file.
        /// </summary>
        PersonalUserFileType Type { get; init; }

        /// <summary>
        /// The name of the personal file.
        /// </summary>
        string Name { get; init; }

        /// <summary>
        /// The caption of the personal file.
        /// </summary>
        string Caption { get; init; }

        /// <summary>
        /// Whether the personal file is accessible.
        /// </summary>
        bool Accessible { get; init; }

        /// <summary>
        /// The source path of the personal file.
        /// </summary>
        string Source { get; init; }

        /// <summary>
        /// The quota of the personal file.
        /// </summary>
        int MaxQuota { get; init; }

        /// <summary>
        /// The compression level of the personal file.
        /// </summary>
        int CompressionLevel { get; init; }
    }
}
