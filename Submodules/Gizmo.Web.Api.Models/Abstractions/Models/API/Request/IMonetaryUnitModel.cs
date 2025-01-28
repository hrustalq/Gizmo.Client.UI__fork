namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Monetary unit.
    /// </summary>
    public interface IMonetaryUnitModel : IWebApiModel
    {
        /// <summary>
        /// The display order of the monetary unit.
        /// </summary>
        int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the monetary unit is deleted.
        /// </summary>
        bool IsDeleted { get; set; }

        /// <summary>
        /// The name of the monetary unit.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The value of the monetary unit.
        /// </summary>
        decimal Value { get; set; }
    }
}