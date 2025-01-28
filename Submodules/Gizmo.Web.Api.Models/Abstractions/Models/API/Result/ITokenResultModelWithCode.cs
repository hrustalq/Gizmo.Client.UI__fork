using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Interface for token results.
    /// </summary>
    /// <typeparam name="TResultCode">Result type.</typeparam>
    /// <remarks>
    /// Provides means to return generated token value and enum code in <see cref="IResultModelCode{T}.Result"/>.
    /// </remarks>
    public interface ITokenResultModelWithCode<TResultCode> : IResultModelCode<TResultCode> where TResultCode : Enum
    {
        /// <summary>
        /// Token value.
        /// </summary>
        string Token { get; set; }

        /// <summary>
        /// Gets confirmation code length.
        /// </summary>
        int CodeLength { get; init; }
    }
}