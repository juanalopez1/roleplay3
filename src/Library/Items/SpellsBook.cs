using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook : MagicalItem
    {
        private int attackValue = 0;
        private int defenseValue = 0;
        private List<ISpell> spells = new List<ISpell>();

        public int AttackValue
        {
            get
            {
                return this.attackValue;
            }
            private set
            {
                int upToDateValue = 0;
                foreach (ISpell spell in this.spells)
                {
                    upToDateValue += spell.AttackValue;
                }
                this.attackValue = upToDateValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return this.defenseValue;
            }
            private set
            {
                int upToDateValue = 0;
                foreach (ISpell spell in this.spells)
                {
                    upToDateValue += spell.DefenseValue;
                }
                this.defenseValue = upToDateValue;

            }
        }

        public void AddSpell(ISpell spell)
        {
            this.spells.Add(spell);
        }

        public void RemoveSpell(ISpell spell)
        {
            this.spells.Remove(spell);
        }
    }
}