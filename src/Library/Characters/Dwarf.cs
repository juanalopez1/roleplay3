using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf : Hero
    {
        private int health = 100;

        private List<Item> items = new List<Item>();

        public Dwarf(string name) : base(name)
        {
            this.AddItem(new Axe(0, 25));
            this.AddItem(new Helmet(25, 0));
        }



    }
}