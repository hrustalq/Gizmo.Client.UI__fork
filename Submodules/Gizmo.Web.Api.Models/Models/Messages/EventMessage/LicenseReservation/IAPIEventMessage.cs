using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(500, typeof(LicenseReservationMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
