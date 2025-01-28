namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Host layout.
    /// </summary>
    public interface IHostLayoutModel : IWebApiModel
    {
        /// <summary>
        /// Display height.
        /// </summary>
        int Height { get; set; }

        /// <summary>
        /// The id of the host.
        /// </summary>
        int HostId { get; set; }

        /// <summary>
        /// Indicates if hidden from layout.
        /// </summary>
        bool IsHidden { get; set; }

        /// <summary>
        /// Display width.
        /// </summary>
        int Width { get; set; }

        /// <summary>
        /// X Position.
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// Y Position.
        /// </summary>
        int Y { get; set; }
    }
}