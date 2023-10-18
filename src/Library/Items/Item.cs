namespace RoleplayGame
{
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Markup;

    public class Item
    {
        public int? DefenseValue = 0;
        public int? AttackValue = 0;
        public string Name { get; set; }

        public Item(string name, int defenseValue, int attackValue)
        {
            this.Name = name;
            this.DefenseValue = defenseValue == 0 ? null : defenseValue;
            this.AttackValue = attackValue == 0 ? null : attackValue;
        }
    }
}