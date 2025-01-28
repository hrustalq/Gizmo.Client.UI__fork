namespace Gizmo.Client
{
    public sealed class AppLinkChangeEventArgs : ModificationEventArgs
    {
        public AppLinkChangeEventArgs(int entityId, ModificationType modificationType) : base(entityId, modificationType)
        {
        }
    }
}
