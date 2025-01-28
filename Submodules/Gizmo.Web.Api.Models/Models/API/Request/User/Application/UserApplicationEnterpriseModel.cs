using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User application enterprise model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserApplicationEnterpriseModel : IUserApplicationEnterpriseModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the enterprise.
        /// </summary>
        [Key(1)]
        public string Name { get; set; } = null!;

        #endregion
    }
}
