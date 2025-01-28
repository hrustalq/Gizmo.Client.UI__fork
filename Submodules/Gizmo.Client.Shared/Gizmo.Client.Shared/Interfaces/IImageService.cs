using Gizmo.UI;

namespace Gizmo.Client
{
    /// <summary>
    /// Service responsible of obtaining Gizmo images (product,app and such)
    /// </summary>
    public interface IImageService
    {
        /// <summary>
        /// Requests image source.
        /// </summary>
        /// <param name="imageType">Image type.</param>
        /// <param name="imageId">Image id.</param>
        /// <param name="cToken">Cancellation token.</param>
        /// <returns>Image source.</returns>
        /// <remarks>
        /// Produced image source url can be directly used as img source of html component.<br></br>
        /// The <paramref name="imageId"/> depends on ImageType, in case of executable or application the <paramref name="imageId"/> should be equal to application or executable id.<br></br>
        /// Since single product can have multiple images in case of product it should be equal to product image id instead of product id itself.<br></br>
        /// The function will only throw <see cref="OperationCanceledException"/>, null is returned in case of an error or <see cref="string.Empty"/> in case image not set.
        /// </remarks>
        /// <exception cref="OperationCanceledException"></exception>
        ValueTask<string> ImageSourceGetAsync(ImageType imageType, int imageId, CancellationToken cToken);

        /// <summary>
        /// Requests image stream.
        /// </summary>
        /// <param name="imageType">Image type.</param>
        /// <param name="imageId">Image id.</param>
        /// <param name="cToken">Cancellation token.</param>
        /// <returns>Image stream.</returns>
        /// <remarks>
        /// The <paramref name="imageId"/> depends on ImageType, in case of executable or application the <paramref name="imageId"/> should be equal to application or executable id.<br></br>
        /// Since single product can have multiple images in case of product it should be equal to product image id instead of product id itself.<br></br>
        /// The function will only throw <see cref="OperationCanceledException"/>, null is returned in case of an error or <see cref="Stream.Null"/> in case image not set.
        /// </remarks>
        /// <exception cref="OperationCanceledException"></exception>
        ValueTask<Stream> ImageStreamGetAsync(ImageType imageType, int imageId, CancellationToken cToken);
    }
}
