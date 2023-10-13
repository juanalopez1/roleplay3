namespace RoleplayGame
{
    public interface ICharacter
    {
        string Name { get; set; }

        int Health { get; }

        int AttackValue { get; }

        int DefenseValue { get; }
        int VictoryPoint { get; }

        void AddItem(IItem item);

        void RemoveItem(IItem item);

        void Cure();

        void ReceiveAttack(int power);
    }
}