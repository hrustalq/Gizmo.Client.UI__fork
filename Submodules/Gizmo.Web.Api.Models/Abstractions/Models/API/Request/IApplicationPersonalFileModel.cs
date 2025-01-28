namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application personal file.
    /// </summary>
    public interface IApplicationPersonalFileModel : IWebApiModel
    {
        /// <summary>
        /// Whether the personal file is accessible.
        /// </summary>
        bool Accessible { get; set; }

        /// <summary>
        /// The activation type of the personal file.
        /// </summary>
        PersonalFileActivationType Activation { get; set; }

        /// <summary>
        /// The caption of the personal file.
        /// </summary>
        string? Caption { get; set; }

        /// <summary>
        /// Whether to clean up before restore.
        /// </summary>
        bool CleanUp { get; set; }

        /// <summary>
        /// The compression level of the personal file.
        /// </summary>
        int CompressionLevel { get; set; }

        /// <summary>
        /// The description of the personal file.
        /// </summary>
        string? Description { get; set; }

        /// <summary>
        /// The directory options object attached to this personal file if the personal file type is file, otherwise it will be null.
        /// </summary>
        ApplicationPersonalFileModelDirectoryOptions? DirectoryOptions { get; set; }

        /// <summary>
        /// The quota of the personal file.
        /// </summary>
        int MaxQuota { get; set; }

        /// <summary>
        /// The name of the personal file.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The source path of the personal file.
        /// </summary>
        string Source { get; set; }

        /// <summary>
        /// Whether to store the personal file.
        /// </summary>
        bool Store { get; set; }

        /// <summary>
        /// The type of the personal file.
        /// </summary>
        PersonalUserFileType Type { get; set; }
    }
}