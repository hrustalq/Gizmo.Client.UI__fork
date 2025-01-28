namespace Gizmo.Client
{
    /// <summary>
    /// Client connection event args.
    /// </summary>
    public sealed class ConnectionStateEventArgs : EventArgs
    {
        /// <summary>
        /// Indicates that a connection is being initiated.
        /// </summary>
        public bool IsConnecting
        {
            get;init;
        }

        /// <summary>
        /// Indicates that a connection is made.
        /// </summary>
        public bool IsConnected
        {
            get;init;
        }
    }
}
