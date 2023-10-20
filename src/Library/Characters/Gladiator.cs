namespace RoleplayGame
{
    using System.Collections.Generic;

    public class Gladiator : Enemy
    {
        private List<Item> items = new List<Item>();

        public Gladiator(string name) : base(name)
        {
            this.AddItem("Shield", 150, 0);
            this.AddItem("Blade", 0, 300);
        }
    }
}