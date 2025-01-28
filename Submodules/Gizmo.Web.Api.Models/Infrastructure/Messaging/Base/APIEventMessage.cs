using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Event base message.
    /// </summary>
    public abstract class APIEventMessage :EventMessage, IAPIEventMessage
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        protected APIEventMessage() : base(ISerializationType)
        { }

        #endregion

        #region READ ONLY FILEDS

        /// <summary>
        /// Serialization type.
        /// </summary>
        public static readonly Type ISerializationType = typeof(IAPIEventMessage);

        #endregion
    }
}
