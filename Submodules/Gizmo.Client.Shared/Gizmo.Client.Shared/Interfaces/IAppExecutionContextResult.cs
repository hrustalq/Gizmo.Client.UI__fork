namespace Gizmo.Client
{
    public interface IAppExecutionContextResult
    {
        /// <summary>
        /// Gets if context was obtained successfully.
        /// </summary>
        public bool IsSuccess { get;}

        /// <summary>
        /// Gets execution context.<br></br>
        /// <b>The vaule will be null if <seealso cref="IsSuccess"/> is equal to false.</b>
        /// </summary>
        public IAppExeExecutionContext? ExecutionContext { get; }
    }
}
