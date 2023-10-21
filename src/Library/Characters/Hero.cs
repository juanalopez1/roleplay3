namespace RoleplayGame
{
    using System;
    using System.Collections.Generic;

    public class Hero : Character
    {
        public int VictoryPoint { get; set; }
        public Hero(string name) : base(name) { }

        public void Attack(Enemy enemy) // Este método no es heredado, porque puede recibir distintos tipos de parámetros. 
        {
            int lifepower = enemy.Health + enemy.DefenseValue;
            if (AttackValue >= lifepower)
            {
                enemy.Health = 0;
                ReceiveVP(enemy);
            }
            else enemy.Health -= AttackValue;
        }
        public void ReceiveVP(Enemy enemy)
        {
            VictoryPoint += enemy.VictoryPoint;
            enemy.VictoryPoint = 0;
        }
    }
}