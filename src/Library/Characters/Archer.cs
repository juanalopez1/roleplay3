namespace RoleplayGame
{
    using System.Collections.Generic;

    public class Archer : Hero
    {
        private List<Item> items = new List<Item>();

        public Archer(string name) : base(name)
        {
            this.AddItem("Bow", 0, 25);
            this.AddItem("Helmet", 50, 0);
        }
    }
}