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

    // IMagicalCharacter wizard = new Hero()
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

    public int VictoryPoint { get; set; }
    public void Cure()
    {
        this.Health = 100;
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
    public void AddItem(Item item)
    {
        this.items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        this.items.Remove(item);
    }
}