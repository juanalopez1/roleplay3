namespace RoleplayGame
{
    public interface IMagicCharacter : ICharacter
    {
        void AddMagicalItem(MagicalItem item);

        void RemoveMagicalItem(MagicalItem item);
    }
}
