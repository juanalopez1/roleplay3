using System.Collections.Generic;

namespace RoleplayGame;

public class Enemy : Character
{
    public Enemy(string name) : base(name) { }
    public string Name { get; set; }
    private List<Item> items = new List<Item>();



}