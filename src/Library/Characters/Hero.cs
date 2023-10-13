using System.Collections.Generic;

namespace RoleplayGame;

public class Hero : ICharacter
{
    public string Name { get; set; }
    private int health = 100;
    private List<Item> items = new List<Item>();

    public Hero(string name)
    {
        this.Name = name;
    }
    public int Health
    {
        get
        {
            return this.health;
        }
        set
        {
            this.health = value < 0 ? 0 : value;
        }
    }
    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (Item item in this.items)
            {
                if (item.AttackValue.HasValue)
                {
                    value += item.AttackValue.Value;
                }
            }
            return value;
        }
    }
    public int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (Item item in this.items)
            {
                if (item.DefenseValue.HasValue)
                {
                    value += item.DefenseValue.Value;
                }
            }
            return value;
        }
    }

    public int VictoryPoint { get; set; }
    public void Cure()
    {
        this.Health = 100;
    }

    public void AddItem(Item item)
    {
        this.items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        this.items.Remove(item);
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
    }
    public void ReceiveVP(Enemy enemy)
    {
        VictoryPoint += enemy.VictoryPoint;
        enemy.VictoryPoint = 0;
    }
}