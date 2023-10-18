namespace RoleplayGame
{
    using System.Collections.Generic;

    public class SpellsBook : MagicalItem
    {
        private int attackValue = 0;
        private int defenseValue = 0;
        private List<Spell> spells = new List<Spell>();
        public SpellsBook(string Name, int AttackValue, int DefenseValue, int Power) : base(Name, AttackValue, DefenseValue, Power) { }

        public new int AttackValue
        {
            get
            {
                return this.attackValue;
            }
            private set
            {
                int upToDateValue = 0;
                foreach (Spell spell in this.spells)
                {
                    upToDateValue += spell.AttackValue;
                }
                this.attackValue = upToDateValue + Power;
            }
        }

        public new int DefenseValue
        {
            get
            {
                return this.defenseValue;
            }
            private set
            {
                int upToDateValue = 0;
                foreach (Spell spell in this.spells)
                {
                    upToDateValue += spell.DefenseValue;
                }
                this.defenseValue = upToDateValue;

            }
        }

        public void AddSpell(Spell spell)
        {
            this.spells.Add(spell);
        }

        public void RemoveSpell(Spell spell)
        {
            this.spells.Remove(spell);
        }
    }
}