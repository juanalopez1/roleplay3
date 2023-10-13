using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf : Hero
    {
        private int health = 100;

        private List<NonMagicalItem> items = new List<NonMagicalItem>();

        public Dwarf(string name) : base(name)
        {
            this.AddItem(new Axe(0, 25));
            this.AddItem(new Helmet());
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

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }


    }
}