namespace RoleplayGame
{
    using System.Collections.Generic;

    public class MagicalHero
    {
        public int VictoryPoint { get; set; }

        public void ReceiveVP(Enemy enemy)
        {
            VictoryPoint += enemy.VictoryPoint;
            enemy.VictoryPoint = 0;
        }

    }
}