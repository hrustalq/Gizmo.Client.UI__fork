using System;
using System.ComponentModel;

namespace Gizmo.Web.Api
{
    /// <summary>
    /// Cursor type converter.
    /// </summary>
    /// <remarks>
    /// This converter is needed in order to make swagger documentation generation work with complex type to string conversion.
    /// <see href="https://github.com/dotnet/aspnetcore/issues/4825"/>
    /// </remarks>
    public sealed class CursorTypeConverter : TypeConverter
    {
        private static readonly Type StringType = typeof(string);

        /// <inheritdoc/>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == StringType;
        }
    }
}
