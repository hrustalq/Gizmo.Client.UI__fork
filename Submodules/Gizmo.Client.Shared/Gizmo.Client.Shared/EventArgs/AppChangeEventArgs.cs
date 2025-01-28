namespace Gizmo.Client;

/// <summary>
/// Server data change args.
/// </summary>
public sealed class AppChangeEventArgs : ModificationEventArgs
{
    public AppChangeEventArgs(int entityId, ModificationType modificationType) : base(entityId, modificationType)
    {
    }
}
