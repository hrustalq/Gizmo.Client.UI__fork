namespace Gizmo.Client
{
    /// <summary>
    /// Image stream result.
    /// </summary>
    public class ImageStreamResult
    {
        public ImageGetResult Result { get; init; } = ImageGetResult.Success;

        /// <summary>
        /// Gets image stream.
        /// </summary>
        /// <remarks>
        /// The value will be equal to <see cref="Stream.Null"/> in case <see cref="Result"/> value not equal to <see cref="ImageGetResult.Success"/>.
        /// </remarks>
        public Stream Stream { get; init; } = Stream.Null;
    }
}
