using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight : Hero
    {
        private List<Item> items = new List<Item>();
        public Knight(string name) : base(name)
        {
            this.Name = name;
            this.AddItem(new Sword(0, 20));
            this.AddItem(new Armor(10, 20));
            this.AddItem(new Shield(20, 30));
        }


    }
}