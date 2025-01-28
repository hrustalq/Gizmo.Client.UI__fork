namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Popular executable.
    /// </summary>
    public interface IPopularExecutableModel : IWebApiModel
    {
        /// <summary>
        /// Total execution time.
        /// </summary>
        public double TotalExecutionTime { get; init; }
    }
}
