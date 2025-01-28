namespace Gizmo.Client;

/// <summary>
/// Server data change args.
/// </summary>
public sealed class AppCategoryChangeEventArgs : ModificationEventArgs
{
    public AppCategoryChangeEventArgs(int entityId, ModificationType modificationType) : base(entityId, modificationType)
    {
    }
}
