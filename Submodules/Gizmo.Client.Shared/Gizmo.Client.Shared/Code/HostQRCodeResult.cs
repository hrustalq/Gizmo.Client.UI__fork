namespace Gizmo.Client
{
    /// <summary>
    /// Host qr code generation result.
    /// </summary>
    public sealed class HostQRCodeResult
    {
        /// <summary>
        /// Generated QR code.
        /// </summary>
        public string QRCode { get; init; } = null!;
    }
}
