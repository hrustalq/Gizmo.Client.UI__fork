using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(100, typeof(EntityChangeEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
