using System;
using System.Collections.Generic;
using System.Linq;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User product bundle model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserProductBundleModel
    {
        /// <summary>
        /// The bundled products in this bundle.
        /// </summary>
        [Key(0)]
        public IEnumerable<UserProductBundledModel> BundledProducts { get; set; } = Enumerable.Empty<UserProductBundledModel>();
    }
}
