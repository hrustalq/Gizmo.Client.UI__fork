namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Popular application.
    /// </summary>
    public interface IPopularApplicationModel : IWebApiModel
    {

        /// <summary>
        /// Total execution time.
        /// </summary>
        public double TotalExecutionTime { get; init; }
    }
}
