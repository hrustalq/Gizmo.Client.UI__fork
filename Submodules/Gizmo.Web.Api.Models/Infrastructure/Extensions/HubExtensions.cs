using Gizmo.Web.Api.Messaging;
using System;

namespace Gizmo.Web.Api
{
    /// <summary>
    /// Singal R Hub extensions.
    /// </summary>
    public static class HubExtensions
    {
        #region FUNCTIONS
        
        /// <summary>
        /// Adds supported Json serializers to the hub options.
        /// </summary>
        /// <param name="options">Json hub options.</param>
        /// <returns>Json hub options.</returns>
        /// <exception cref="ArgumentNullException">thrown in case <paramref name="options"/>being equal to null.</exception>
        public static Microsoft.AspNetCore.SignalR.JsonHubProtocolOptions AddConverters(this Microsoft.AspNetCore.SignalR.JsonHubProtocolOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            //add event message converter
            options.PayloadSerializerOptions.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPIEventMessage>("EventId", "Event"));

            //add command message converter
            options.PayloadSerializerOptions.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPICommandMessage>("CommandId", "Command"));

            //add control message converter
            options.PayloadSerializerOptions.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPIControlMessage>("ControlId", "Control"));

            if (DynamicConverterLoader.TryCreate("Gizmo.Companion.Shared", "ICompanionCommandMessage", out var converter))
            {
                options.PayloadSerializerOptions.Converters.Add(converter);
            }

            return options;
        } 

        #endregion
    }
}
