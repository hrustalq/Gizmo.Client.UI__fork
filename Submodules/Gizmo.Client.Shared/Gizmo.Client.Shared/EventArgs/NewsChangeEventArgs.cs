namespace Gizmo.Client;

/// <summary>
/// Server data change args.
/// </summary>
public sealed class NewsChangeEventArgs : ModificationEventArgs
{
    public NewsChangeEventArgs(int entityId, ModificationType modificationType) : base(entityId, modificationType)
    {
    }
}
