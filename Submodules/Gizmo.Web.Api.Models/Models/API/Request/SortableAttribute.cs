using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    ///  Used to provide a name for a sortable property for a model.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class SortableAttribute : Attribute
    {
        /// <summary>
        ///  Sortable property name that will be mapped on the server Entity property name.
        /// </summary>
        public string? Name { get; }

        /// <summary>
        ///  Creates new instance.
        /// </summary>
        /// <param name="name">Sortable property name that will be mapped on the server Entity property name.</param>
        public SortableAttribute(string? name = null) => Name = name;
    }
}
