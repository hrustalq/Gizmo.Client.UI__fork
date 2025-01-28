namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Variable.
    /// </summary>
    public interface IVariableModel : IWebApiModel
    {
        /// <summary>
        /// The name of the variable.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        string Value { get; set; }

        /// <summary>
        /// Whether the variable is available in server.
        /// </summary>
        bool AvailableInServer { get; set; }

        /// <summary>
        /// Whether the variable is available in client.
        /// </summary>
        bool AvailableInClient { get; set; }

        /// <summary>
        /// Whether the variable is available in manager.
        /// </summary>
        bool AvailableInManager { get; set; }
    }
}