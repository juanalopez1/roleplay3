namespace RoleplayGame
{
    using System.Collections.Generic;

    public class Goblin : Enemy
    {
        private List<Item> items = new List<Item>();

        public Goblin(string name) : base(name)
        {
            this.AddItem("Ring", 0, 100);
        }
    }
}