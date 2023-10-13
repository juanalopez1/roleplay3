namespace RoleplayGame
{
    public class SpellOne : ISpell // NO MIRE LOS SPELLS !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    {
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
        public SpellOne(int defenseValue, int attackValue)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
        }
    }
}