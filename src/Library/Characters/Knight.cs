namespace RoleplayGame
{
    using System.Collections.Generic;

    public class Knight : Hero
    {
        private List<Item> items = new List<Item>();
        public Knight(string name) : base(name)
        {
            this.Name = name;
            this.AddItem(new Item("Sword", 0, 20));
            this.AddItem(new Item("Armor", 10, 20));
            this.AddItem(new Item("Shield", 20, 30));
        }


    }
}