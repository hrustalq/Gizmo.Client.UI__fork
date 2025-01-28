using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Verification result for email.
    /// </summary>
    public interface ITokenResultModelWithEmailCode<TResultCode> : ITokenResultModelWithCode<TResultCode> where TResultCode : Enum
    {
        /// <summary>
        /// Gets email address.
        /// </summary>
        string Email { get; set; }
    }
}