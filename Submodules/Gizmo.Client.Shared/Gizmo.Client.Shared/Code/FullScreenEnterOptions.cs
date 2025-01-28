namespace Gizmo.Client
{
    /// <summary>
    /// Full screen enter options.
    /// </summary>
    public sealed class FullScreenEnterOptions
    {
        public static readonly FullScreenEnterOptions Default = new();

        /// <summary>
        /// Indicates that the window should become topmost.
        /// </summary>
        /// <remarks>
        /// Default value is true.
        /// </remarks>
        public bool TopMost { get; init; } = true;
    }
}
