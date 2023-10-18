namespace RoleplayGame
{
    public class Spell
    {
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
        public Spell(int defenseValue, int attackValue)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
        }
    }
}