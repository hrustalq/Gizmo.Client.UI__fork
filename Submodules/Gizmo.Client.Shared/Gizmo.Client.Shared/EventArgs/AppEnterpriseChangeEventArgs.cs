namespace Gizmo.Client;

/// <summary>
/// Server data change args.
/// </summary>
public sealed class AppEnterpriseChangeEventArgs : ModificationEventArgs
{
    public AppEnterpriseChangeEventArgs(int entityId, ModificationType modificationType) : base(entityId, modificationType)
    {
    }
}
