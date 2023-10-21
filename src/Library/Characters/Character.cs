namespace RoleplayGame
{
    using System.Collections.Generic;
    using System.Data;
    using Microsoft.VisualBasic;

    public class Character
    {
        private string Name { get; set; }

        private int health = 100;

        private List<Item> items = new List<Item>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Character"/> class.
        /// </summary>
        /// <param name="name">asdasdsa.</param>
        public Character(string name)
        {
            this.Name = name;
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Item item in this.items)
                {
                    if (item.AttackValue.HasValue)
                    {
                        value += item.AttackValue.Value;
                    }
                }
                return value;
            }
        }
        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Item item in this.items)
                {
                    if (item.DefenseValue.HasValue)
                    {
                        value += item.DefenseValue.Value;
                    }
                }
                return value;
            }
        }

        public void AddItem(string name, int defenseValue, int attackValue)
        {
            this.items.Add(new Item(name, defenseValue, attackValue));
        }

        public void RemoveItem(Item item)
        {
            this.items.Remove(item);
        }
        public void Cure()
        {
            this.Health = 100;
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }

        }
    }
}