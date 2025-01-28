using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(400, typeof(WaitingLineEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
