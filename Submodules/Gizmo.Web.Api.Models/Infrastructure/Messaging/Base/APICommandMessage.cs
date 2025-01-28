using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Command message.
    /// </summary>
    public abstract class APICommandMessage : CommandMessage, IAPICommandMessage
    {
        #region CONSTRUCTOR
        
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public APICommandMessage() : base(ISerializationType)
        { }

        #endregion

        #region READ ONLY FILEDS
        
        /// <summary>
        /// Serialization type.
        /// </summary>
        public static readonly Type ISerializationType = typeof(IAPICommandMessage); 

        #endregion
    }
}
