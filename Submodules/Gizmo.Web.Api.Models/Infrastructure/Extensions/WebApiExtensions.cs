using Gizmo.Web.Api.Messaging;
using System;
using System.Text.Json;

namespace Gizmo.Web.Api
{
    /// <summary>
    /// Web api json options configuration extensions.
    /// </summary>
    public static class WebApiExtensions
    {
        #region FUNCTIONS
        
        /// <summary>
        /// Adds supported Json serializers to the web api json options.
        /// </summary>
        /// <param name="options">Json options.</param>
        /// <returns>Json serializer options.</returns>
        /// <exception cref="ArgumentNullException">thrown in case <paramref name="options"/>being equal to null.</exception>
        public static JsonSerializerOptions AddConverters(this JsonSerializerOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            options.Converters.Add(new MessagePackUnionMessageJsonConverter<Models.WebApiErrorBase>("ErrorType", "Error"));

            //add event message converter
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPIEventMessage>("EventId", "Event"));

            //add command message converter
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPICommandMessage>("CommandType", "Command"));

            //add control message converter
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPIControlMessage>("ControlType", "Command"));

            return options;
        } 

        #endregion
    }
}
