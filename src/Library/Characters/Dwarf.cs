namespace RoleplayGame
{
    using System.Collections.Generic;

    public class Dwarf : Hero
    {
        private List<Item> items = new List<Item>();

        public Dwarf(string name) : base(name)
        {
            this.AddItem("Axe", 0, 25);
            this.AddItem("Helmet", 25, 0);
        }
    }
}