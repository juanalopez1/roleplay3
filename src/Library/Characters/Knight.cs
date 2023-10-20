namespace RoleplayGame
{
    using System.Collections.Generic;

    public class Knight : Hero
    {
        private List<Item> items = new List<Item>();
        public Knight(string name) : base(name)
        {
            this.AddItem("Sword", 0, 20);
            this.AddItem("Armor", 10, 20);
            this.AddItem("Shield", 20, 30);
        }


    }
}