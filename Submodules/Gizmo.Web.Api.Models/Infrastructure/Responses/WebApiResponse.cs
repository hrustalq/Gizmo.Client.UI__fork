using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Generic web api response with result.
    /// </summary>
    /// <typeparam name="T">Result type.</typeparam>
    [MessagePackObject()]
    public class WebApiResponse<T> : WebApiResponseBase
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WebApiResponse() {}

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="result">Result type.</param>
        /// <param name="statusCode">HTTP Status code.</param>
        public WebApiResponse(T result, int statusCode) : base(statusCode)
        {
            Result = result;
        } 

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Get response version.
        /// </summary>
        [Key(3)]
        public string Version
        {
            get;set;
        }

        /// <summary>
        /// Gets response result.
        /// </summary>
        [Key(4)]
        public T Result { get; set; }

        #endregion
    }
}
