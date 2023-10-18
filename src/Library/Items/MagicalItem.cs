namespace RoleplayGame;
public class MagicalItem : Item
{
    public int Power { get; set; }
    public MagicalItem(string name, int AttackValue, int DefenseValue, int power) : base(name, AttackValue, DefenseValue)
    {
        this.Power = power;
    }
}