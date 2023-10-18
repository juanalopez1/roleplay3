namespace RoleplayGame
{
    using System.Collections.Generic;

    public class Dwarf : Hero
    {
        private List<Item> items = new List<Item>();

        public Dwarf(string name) : base(name)
        {
            this.AddItem(new Item("Axe", 0, 25));
            this.AddItem(new Item("Helmet", 25, 0));
        }
    }
}