namespace RoleplayGame;
public class MagicalItem : Item
{
    public int Power { get; set; }
    public MagicalItem(int AttackValue, int DefenseValue, int power) : base(AttackValue, DefenseValue)
    {
        this.Power = power;
    }
}
