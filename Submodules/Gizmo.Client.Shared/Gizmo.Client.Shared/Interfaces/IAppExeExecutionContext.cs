namespace Gizmo.Client
{
    /// <summary>
    /// Represents app exe execution state.
    /// </summary>
    public interface IAppExeExecutionContext
    {
        /// <summary>
        /// Indicates that application should launched automatically after deployment.
        /// </summary>
        bool AutoLaunch { get; set; }

        /// <summary>
        /// Gets if context is alive, effectively if any processes being tracked for this context.
        /// </summary>
        public bool IsAlive { get; }

        /// <summary>
        /// Gets if execution is in progress.<br></br>Esentially if the application being started.
        /// </summary>
        bool IsExecuting
        {
            get;
        }

        /// <summary>
        /// Gets if execution is being aborted.<br></br>Esentially if application start is being canceled.
        /// </summary>
        bool IsAborting
        {
            get;
        }

        /// <summary>
        /// Gets if execution where previously completed with succcess.<br></br>Esentially if application was started normally at least once.
        /// </summary>
        bool HasCompleted { get; }

        /// <summary>
        /// Executes context.
        /// </summary>
        /// <param name="reprocess">Indicates that reprocessing should be done.</param>
        /// <param name="cancellationToken">Cancellation token.</param>  
        /// <exception cref="ArgumentException">thrown if context is already executing.</exception>
        public Task ExecuteAsync(bool reprocess, CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminates execution context.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <remarks>
        /// The function will try to kill any running processes in the context, once all the processes exit it will cause the context to finalize.
        /// </remarks>
        public Task TerminateAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Asynchronously aborts execution.
        /// </summary>
        /// <exception cref="ArgumentException">thrown if already aborting.</exception>
        public Task AbortAsync();

        /// <summary>
        /// Tries to activate tracked processes window. 
        /// </summary>
        /// <remarks>
        /// Effectively this function tries to bring any window in tracked processes into foreground.
        /// </remarks>
        /// <returns>True if at least one window was activated.</returns>
        Task<bool> TryActivateAsync(CancellationToken cancellationToken = default);
    }
}
