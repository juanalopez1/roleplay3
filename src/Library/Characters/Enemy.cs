namespace RoleplayGame;

public class Enemy : ICharacter
{
    public string Name { get; set; }

    public int Health { get; set; }

    public int AttackValue { get; set; }

    public int DefenseValue { get; set; }
    public int VictoryPoint { get; set; }

    public void AddItem(NonMagicalItem item) { }

    public void Cure() { }

    public void ReceiveAttack(int power) { }

    public void RemoveItem(NonMagicalItem item) { }

}