using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Control message.
    /// </summary>
    public abstract class APIControlMessage :ControlMessage, IAPIControlMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public APIControlMessage() : base(ISerializationType)
        { }
        #endregion

        #region READ ONLY FILEDS

        /// <summary>
        /// Serialization type.
        /// </summary>
        public static readonly Type ISerializationType = typeof(IAPIControlMessage);

        #endregion
    }
}
