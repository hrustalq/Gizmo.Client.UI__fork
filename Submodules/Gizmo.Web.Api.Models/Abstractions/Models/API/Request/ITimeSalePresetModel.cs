namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Time sale preset.
    /// </summary>
    public interface ITimeSalePresetModel : IWebApiModel
    {
        /// <summary>
        /// The value of the time sale preset.
        /// </summary>
        int Value { get; set; }

        /// <summary>
        /// The display order of the time sale preset.
        /// </summary>
        int DisplayOrder { get; set; }
    }
}