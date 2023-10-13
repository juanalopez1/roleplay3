using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Markup;

namespace RoleplayGame
{
    public class Item
    {
        public int? DefenseValue = 0;
        public int? AttackValue = 0;

        public Item(int defenseValue, int attackValue)
        {
            this.DefenseValue = defenseValue == 0 ? null : defenseValue;
            this.AttackValue = attackValue == 0 ? null : attackValue;
        }
    }
}