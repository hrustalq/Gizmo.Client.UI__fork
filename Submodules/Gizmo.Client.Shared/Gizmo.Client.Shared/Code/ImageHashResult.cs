namespace Gizmo.Client
{
    /// <summary>
    /// Image hash result.
    /// </summary>
    public sealed class ImageHashResult
    {
        /// <summary>
        /// Gets image hash.
        /// </summary>
        /// <remarks>
        /// The value will be null in case <see cref="Result"/> value not equal to <see cref="ImageGetResult.Success"/>.
        /// </remarks>
        public string? Hash { get; init; }

        /// <summary>
        /// Gets result.
        /// </summary>
        public ImageGetResult Result { get; init; } = ImageGetResult.Success;
    }
}
