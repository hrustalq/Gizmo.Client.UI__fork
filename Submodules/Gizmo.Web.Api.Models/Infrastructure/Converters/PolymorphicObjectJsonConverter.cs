using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api
{
    /// <summary>
    /// Polymorphic object json converter.
    /// </summary>
    /// <typeparam name="T">The type of object or value handled by the converter.</typeparam>
    public abstract class PolymorphicObjectJsonConverter<T> : JsonConverter<T>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Default constructor.
        /// </summary>
        public PolymorphicObjectJsonConverter()
        { }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="descriminatorName">Custom discrimantor name.</param>
        /// <exception cref="ArgumentNullException">thrown if value specified by <paramref name="descriminatorName"/>is null or empty string.</exception>
        public PolymorphicObjectJsonConverter(string descriminatorName)
        {
            if (string.IsNullOrEmpty(descriminatorName))
                throw new ArgumentNullException(nameof(descriminatorName));

            DESCRIMINATOR_NAME = descriminatorName;
        } 

        #endregion

        #region FIELDS

        private readonly string DESCRIMINATOR_NAME = DEFAULT_DESCRIMINATOR_NAME;
        private const string DEFAULT_DESCRIMINATOR_NAME = "MessageType";

        #endregion

        #region HELPERS

        /// <summary>
        /// Reads object descriminator.
        /// </summary>
        /// <param name="reader">Json reader.</param>
        /// <returns>Object desciminator.</returns>
        protected virtual int ReadDescriminator(ref Utf8JsonReader reader)
        {
            reader.Read();
            if (reader.TokenType != JsonTokenType.PropertyName)
                throw new JsonException();

            string? propertyName = reader.GetString();
            if (propertyName == null || propertyName != DESCRIMINATOR_NAME)
                throw new JsonException();

            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
                throw new JsonException();

            return reader.GetInt32();
        }

        /// <summary>
        /// Writes descriminator.
        /// </summary>
        /// <param name="writer">Json writer.</param>
        /// <param name="descriminator">Desciminator.</param>
        protected virtual void WriteDescriminator(Utf8JsonWriter writer, int descriminator)
        {
            writer.WriteNumber(DESCRIMINATOR_NAME, descriminator);
        }

        #endregion
    }
}
