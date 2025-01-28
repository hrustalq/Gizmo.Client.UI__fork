namespace Gizmo.Client;

/// <summary>
/// Server data change args.
/// </summary>
public sealed class FeedChangeEventArgs : ModificationEventArgs
{
    public FeedChangeEventArgs(int entityId, ModificationType modificationType) : base(entityId, modificationType)
    {
    }
}
