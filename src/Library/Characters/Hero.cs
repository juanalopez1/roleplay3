namespace RoleplayGame
{
    using System.Collections.Generic;

    public class Hero : Character
    {
        public int VictoryPoint { get; set; }
        public Hero(string name) : base(name) { }
        public void ReceiveVP(Enemy enemy)
        {
            VictoryPoint += enemy.VictoryPoint;
            enemy.VictoryPoint = 0;
        }
    }
}