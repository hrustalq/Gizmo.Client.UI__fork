namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User application enterprise model.
    /// </summary>
    public interface IUserApplicationEnterpriseModel : IWebApiModel
    {
        /// <summary>
        /// The name of the enterprise.
        /// </summary>
        string Name { get; set; }
    }
}
