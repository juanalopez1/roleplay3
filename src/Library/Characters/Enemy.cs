using System;

namespace RoleplayGame
{
    public class Enemy : Character
    {
        public int VictoryPoint { get; set; }
        public Enemy(string Name) : base(Name) { }

        public void Attack(Character character)
        {
            int lifepower = character.Health + character.DefenseValue;
            if (AttackValue > lifepower)
                character.Health = 0;
            else character.Health -= AttackValue;
        }

    }
}