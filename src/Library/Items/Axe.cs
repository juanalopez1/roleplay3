namespace RoleplayGame
{
    public class Axe : NonMagicalItem
    {
        public Axe(int defenseValue, int attackValue) : base(defenseValue, attackValue)
        {
            this.DefenseValue = defenseValue;
            this.DefenseValue = attackValue;
        }
    }
}