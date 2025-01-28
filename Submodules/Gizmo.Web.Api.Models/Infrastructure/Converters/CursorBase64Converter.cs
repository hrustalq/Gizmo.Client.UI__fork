using System;
using Gizmo.Web.Api.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Gizmo.Web.Api
{
    /// <summary>
    /// Converts pagination cursor to base64 encoded json string.
    /// </summary>
    public sealed class CursorBase64Converter : JsonConverter<PaginationCursor>
    {
        /// <inheritdoc/>
        public override PaginationCursor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var bytes = reader.GetBytesFromBase64();
            var jsonReader = new Utf8JsonReader(bytes);
            return Read(ref jsonReader);

        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, PaginationCursor value, JsonSerializerOptions options) =>
            writer.WriteBase64StringValue(JsonSerializer.SerializeToUtf8Bytes(value, options));

        /// <summary>
        /// Reads cursor from specified json reader.
        /// </summary>
        /// <param name="jsonReader">Json reader.</param>
        /// <returns>Read cursor.</returns>
        public static PaginationCursor Read(ref Utf8JsonReader jsonReader)
        {
            //parse the cursor
            var pcursor = new PaginationCursor();

            while (jsonReader.Read())
            {
                if (jsonReader.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = jsonReader.GetString()?.ToLower();
                    jsonReader.Read();
                    switch (propertyName)
                    {
                        case "id":
                            pcursor.Id = jsonReader.GetInt32();
                            break;
                        case "name":
                            pcursor.Name = jsonReader.GetString()!;
                            break;
                        case "value":
                            pcursor.Value = jsonReader.GetString()!;
                            break;
                        case "isforward":
                            pcursor.IsForward = jsonReader.GetBoolean();
                            break;
                        case "isasc":
                            pcursor.IsAsc = jsonReader.GetBoolean();
                            break;
                    }
                }
            }
            return pcursor;
        }
    }
}
