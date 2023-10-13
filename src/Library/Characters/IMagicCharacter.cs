namespace RoleplayGame
{
    public interface IMagicCharacter
    {
        string Name { get; set; }

        int Health { get; }

        int AttackValue { get; }

        int DefenseValue { get; }
        int VictoryPoint { get; }

        void AddItem(MagicalItem item);

        void RemoveItem(MagicalItem item);
        void Cure();

        void ReceiveAttack(int power);
    }
}
