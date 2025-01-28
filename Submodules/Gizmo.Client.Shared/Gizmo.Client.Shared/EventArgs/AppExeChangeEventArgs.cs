namespace Gizmo.Client;

/// <summary>
/// Server data change args.
/// </summary>
public sealed class AppExeChangeEventArgs : ModificationEventArgs
{
    public AppExeChangeEventArgs(int entityId, ModificationType modificationType) : base(entityId, modificationType)
    {
    }
}
