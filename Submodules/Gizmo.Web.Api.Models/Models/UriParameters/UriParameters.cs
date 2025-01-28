using Gizmo.Web.Api.Models.Abstractions;

using Microsoft.AspNetCore.WebUtilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// URI parameters converter
    /// </summary>
    public readonly struct UriParameters : IUriParameters
    {
        /// <summary>
        /// Query parameters from ModelFilter as string
        /// </summary>
        public string? Query { get; }
        /// <summary>
        /// Path parameters from WebClient API as string
        /// </summary>
        public string? Path { get; }

        /// <summary>
        /// An instance sets the Query property as NULL and the Path property as NULL.
        /// </summary>
        public UriParameters()
        {
            Path = null;
            Query = null;
        }

        /// <summary>
        /// An instance sets the Path property as /{id} and the Query property as NULL.
        /// </summary>
        /// <param name="id">Identifier entity</param>
        public UriParameters(int id)
        {
            Path = $"/{id}";
            Query = null;
        }

        /// <summary>
        /// An instance sets the Path property as /{pathParameters[0]}/{pathParameters[1]}/...} and the Query property as NULL.
        /// </summary>
        /// <param name="pathParameters">An array which will be serialized to the string for URI.Path</param>
        public UriParameters(object[] pathParameters)
        {
            Path = BuildUriPath(pathParameters);
            Query = null;
        }

        /// <summary>
        /// An instance sets the Query property as ?{prop.name}={prop.value} and the Path property as NULL.
        /// </summary>
        /// <param name="queryParameters">An object which will be serialized to the string for URI.Query.</param>
        public UriParameters(IUriParametersQuery queryParameters)
        {
            Query = BuildUriQuery(queryParameters);
            Path = null;
        }

        /// <summary>
        /// An instance sets the Query property as ?{prop.name}={prop.value}and the Path property as /{pathParameters[0]}/{pathParameters[1]}/...}
        /// </summary>
        /// <param name="pathParameters">An array which will be serialized to the string for URI.Path</param>
        /// <param name="queryParameters">An object which will be serialized to the string for URI.Query.</param>
        public UriParameters(object[] pathParameters, IUriParametersQuery queryParameters)
        {
            Path = BuildUriPath(pathParameters);
            Query = BuildUriQuery(queryParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string BuildUriQuery(IUriParametersQuery queryParameters)
        {
            var queryStringParameters = new Dictionary<string, string>();

            ParseObjectForQueryStringParameters(queryParameters);

            return QueryHelpers.AddQueryString(string.Empty, queryStringParameters);

            void ParseObjectForQueryStringParameters(object data, string? propName = null)
            {
                if (data.GetType().IsClass)
                {
                    var serializedObject = JsonSerializer.Serialize(data);
                    var serializedObjectAsDictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(serializedObject);

                    if (serializedObjectAsDictionary is null)
                        throw new NotSupportedException($"The method '{nameof(ParseObjectForQueryStringParameters)}' can't parse the {typeof(IUriParametersQuery).Name}.");

                    foreach (var item in serializedObjectAsDictionary.Where(x => x.Value is not null))
                        ParseObjectForQueryStringParameters(item.Value, propName is null ? item.Key : $"{propName}.{item.Key}");
                }
                else
                {
                    var serializedJsonElement = (JsonElement)data;

                    switch (serializedJsonElement.ValueKind)
                    {
                        case JsonValueKind.Array:
                            {
                                var serializedJsonElementArray = serializedJsonElement.Deserialize<object[]>();

                                if (serializedJsonElementArray is null)
                                    throw new NotSupportedException($"The method '{nameof(ParseObjectForQueryStringParameters)}' can't parse the {typeof(IUriParametersQuery).Name}.");

                                for (int i = 0; i < serializedJsonElementArray.Length; i++)
                                    ParseObjectForQueryStringParameters(serializedJsonElementArray[i], $"{propName}[{i}]");

                                break;
                            }
                        case JsonValueKind.Object:
                            {
                                var serializedJsonElementObject = serializedJsonElement.Deserialize<Dictionary<string, object>>();

                                if (serializedJsonElementObject is null)
                                    throw new NotSupportedException($"The method '{nameof(ParseObjectForQueryStringParameters)}' can't parse the {typeof(IUriParametersQuery).Name}.");

                                foreach (var item in serializedJsonElementObject.Where(x => x.Value is not null))
                                    ParseObjectForQueryStringParameters(item.Value, $"{propName}.{item.Key}");

                                break;
                            }
                        default:
                            {
                                queryStringParameters.Add(propName!, data.ToString());

                                break;
                            }
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string BuildUriPath(object[] pathParameters) => '/' + string.Join("/", pathParameters);
    }
}
