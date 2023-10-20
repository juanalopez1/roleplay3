namespace RoleplayGame
{
    public class Enemy : Character
    {
        public int VictoryPoint { get; set; }
        public Enemy(string Name) : base(Name) { }
    }
}