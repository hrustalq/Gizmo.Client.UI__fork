namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application enterprise.
    /// </summary>
    public interface IApplicationEnterpriseModel : IWebApiModel
    {
        /// <summary>
        /// The name of the enterprise.
        /// </summary>
        string Name { get; set; }
    }
}