namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Register.
    /// </summary>
    public interface IRegisterModel : IWebApiModel
    {
        /// <summary>
        /// The idle timeout of the register.
        /// </summary>
        int? IdleTimeout { get; set; }

        /// <summary>
        /// The MAC address of the register.
        /// </summary>
        string? MacAddress { get; set; }

        /// <summary>
        /// The name of the register.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The number of the register.
        /// </summary>
        int Number { get; set; }

        /// <summary>
        /// The start cash of the register.
        /// </summary>
        decimal StartCash { get; set; }
    }
}