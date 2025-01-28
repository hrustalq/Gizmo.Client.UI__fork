namespace Gizmo.Client;

/// <summary>
/// Server data change args.
/// </summary>
public sealed class HostGroupChangeEventArgs : ModificationEventArgs
{
    public HostGroupChangeEventArgs(int entityId, ModificationType modificationType) : base(entityId, modificationType)
    {
    }
}
