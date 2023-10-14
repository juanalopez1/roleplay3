namespace RoleplayGame;

public class Enemy : Character
{
    private int health = 100;
    public Enemy(string name) : base(name) { }
    public string Name { get; set; }


}