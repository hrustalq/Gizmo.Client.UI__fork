namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Filter for cursor-based pagination.
    /// </summary>
    public interface IModelFilterPagination
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        public ModelFilterPagination Pagination { get; set; }
    }
}
