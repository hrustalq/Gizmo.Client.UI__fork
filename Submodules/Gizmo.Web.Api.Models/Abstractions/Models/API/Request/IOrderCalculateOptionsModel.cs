using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Calculate order options.
    /// </summary>
    public interface IOrderCalculateOptionsModel : IWebApiModel
    {
        /// <summary>
        /// The lines of the order.
        /// </summary>
        IEnumerable<OrderLineModelOptions> OrderLines { get; set; }
    }
}