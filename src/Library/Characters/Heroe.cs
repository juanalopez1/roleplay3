namespace RoleplayGame;

public class Heroe : ICharacter
{
    public string Name { get; set; }

    public int Health{ get; set; }

    public int AttackValue { get; set; }

    public int DefenseValue { get; set; }

    public int VictoryPoint { get; set; }

    public void AddItem(IItem item) { }

    public void Cure() { }

    public void ReceiveAttack(int power) { }

    public void RemoveItem(IItem item) { }
    public void ReceiveVP(Enemy enemy)
    {
        VictoryPoint += enemy.VictoryPoint;
    }
}