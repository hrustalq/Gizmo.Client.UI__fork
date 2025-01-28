namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User attribute.
    /// </summary>
    public interface IUserAttributeModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the attribute this user attribute is associated with.
        /// </summary>
        int AttributeId { get; set; }

        /// <summary>
        /// The value of the user attribute.
        /// </summary>
        string Value { get; set; }
    }
}