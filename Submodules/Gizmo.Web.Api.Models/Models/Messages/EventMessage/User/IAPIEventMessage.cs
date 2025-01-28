using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(300, typeof(UserBalanceChangeEventMessage))]
    [Union(301, typeof(UserSessionChangedEventMessage))]
    [Union(302, typeof(UserBalanceCloseEventMessage))]
    [Union(303, typeof(UserEnabledChangedEventMessage))]
    [Union(304, typeof(UserEmailChangedEventMessage))]
    [Union(305, typeof(UserEnableNegativeBalanceEventMessage))]
    [Union(306, typeof(UserUsageSessionChangedEventArgs))]
    [Union(307, typeof(UserGroupChangedEventMessage))]
    [Union(308, typeof(UserPictureChangedEventMessage))]
    [Union(309, typeof(UserLoginStateChangedEventMessage))]
    [Union(310, typeof(UserSmartCardChangeEventMessage))]
    [Union(311, typeof(UserRenamedEventMessage))]
    [Union(312, typeof(UserPasswordChangedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
