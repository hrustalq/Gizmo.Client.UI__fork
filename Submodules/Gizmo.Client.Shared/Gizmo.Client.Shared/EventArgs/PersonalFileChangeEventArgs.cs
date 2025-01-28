namespace Gizmo.Client
{
    public sealed class PersonalFileChangeEventArgs : ModificationEventArgs
    {
        public PersonalFileChangeEventArgs(int entityId, ModificationType modificationType) : base(entityId, modificationType)
        {
        }
    }
}
