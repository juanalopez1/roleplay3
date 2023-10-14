using System.Collections.Generic;

namespace RoleplayGame;

public class Hero : Character
{
    public string Name { get; set; }
    private int health = 100;
    private List<Item> items = new List<Item>();

    public Hero(string name) : base(name)
    {
        this.Name = name;
    }

    // IMagicalCharacter wizard = new Hero()

    public void ReceiveVP(Enemy enemy)
    {
        VictoryPoint += enemy.VictoryPoint;
        enemy.VictoryPoint = 0;
    }

}