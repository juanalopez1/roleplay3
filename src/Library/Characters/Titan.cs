namespace RoleplayGame
{
    using System.Collections.Generic;

    public class Titan : Enemy
    {
        private List<Item> items = new List<Item>();

        public Titan(string name) : base(name)
        {
            this.AddItem("Gauntlet", 0, 200);
            this.AddItem("Space Stone", 200, 0);

        }
    }
}