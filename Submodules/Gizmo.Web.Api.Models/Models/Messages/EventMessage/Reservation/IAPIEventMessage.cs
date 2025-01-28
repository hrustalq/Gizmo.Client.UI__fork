using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(600, typeof(ReservationEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
