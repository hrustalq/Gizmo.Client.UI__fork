namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Filter.
    /// </summary>
    public interface IModelFilter<T> : IModelFilterPagination, IModelFilterOptions, IUriParametersQuery where T : class, IWebApiModel
    {
    }
}
