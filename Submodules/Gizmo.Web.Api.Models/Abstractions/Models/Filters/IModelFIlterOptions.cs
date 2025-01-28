using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Specified objects in the result.
    /// </summary>
    public interface IModelFilterOptions : IUriParametersQuery
    {
        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        List<string> Expand { get; set; }
    }
}
