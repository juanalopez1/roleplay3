namespace RoleplayGame
{
    using System.Collections.Generic;

    public class Wizard : IMagicalCharacter
    {
        private int health = 100;

        private List<MagicalItem> magicalItems = new List<MagicalItem>();

        public Wizard(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        /// <AttackValue>AttackValue</AttackValue>
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (MagicalItem item in this.magicalItems)
                {
                    value += item.AttackValue.Value;

                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (MagicalItem item in magicalItems)
                    value += item.DefenseValue.Value;

                return value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddItem(MagicalItem item)
        {
            this.magicalItems.Add(item);
        }


        public void RemoveItem(MagicalItem item)
        {
            this.magicalItems.Remove(item);
        }

        public int VictoryPoint { get; set; }

    }
}