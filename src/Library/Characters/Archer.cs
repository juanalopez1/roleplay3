using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer : Hero
    {
        private int health = 100;

        private List<Item> items = new List<Item>();

        public Archer(string name) : base(name)
        {
            this.AddItem(new Bow(0, 25));
            this.AddItem(new Helmet(50, 0));
        }
    }
}