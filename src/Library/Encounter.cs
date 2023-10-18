using System.Collections.Generic;

namespace RoleplayGame
{
    using System.Collections.Generic;

    public class Encounter
    {
        public Encounter()
        {
            this.Heros = new List<Hero>();
            this.Enemies = new List<Enemy>();
        }
        public List<Hero> Heros { get; }

        public List<Enemy> Enemies { get; }
        public void DoEncounter()
        {
            while (Heros.Count != 0 || Enemies.Count != 0)
            {
                if (Heros.Count == 1)
                    // primer ataque de enemigos si hay un solo heroe
                    for (int i = 0; i < Heros.Count; i++)
                    {
                        Hero hero = Heros[0];
                        Enemy enemy = Enemies[i];
                        hero.Health -= enemy.AttackValue;

                        // si el heroe queda vivo, ataca el al enemigo ahora...
                        if (Heros[0].Health > 0)
                        {
                            enemy.Health -= Heros[0].AttackValue;

                            EnemysDeath(enemy, Heros[0]);
                            HealHero(Heros[0]);
                        }
                        else
                            Heros.Remove(Heros[0]);
                        i--;

                    }

                else if (Heros.Count > 0 && Enemies.Count > 0  // uno para cada uno (1 vs 1)
                    && Heros.Count == Enemies.Count)
                {
                    for (int i = 0; i < Heros.Count; i++)
                    {
                        Hero hero = Heros[i];
                        Enemy enemy = Enemies[i];

                        hero.Health -= enemy.AttackValue;

                        if (hero.Health > 0)
                        {
                            enemy.Health -= hero.AttackValue;
                            EnemysDeath(enemy, hero);
                            HealHero(hero);
                        }
                        else
                            Heros.Remove(hero);
                        i--;
                    }
                }


                else if (Heros.Count < Enemies.Count)   // menos heroes que enemigos
                {
                    for (int i = 0; i < Heros.Count; i++)
                    {
                        Hero hero = Heros[i];
                        Enemy enemy = Enemies[i];
                        Enemy enemy2 = Enemies[i + 1];

                        hero.Health -= enemy.AttackValue + enemy2.AttackValue;

                        if (hero.Health > 0)
                        {
                            enemy.Health -= hero.AttackValue;
                            enemy2.Health -= hero.AttackValue;
                            EnemysDeath(enemy, hero);
                            EnemysDeath(enemy2, hero);
                            HealHero(hero);
                        }
                        else
                            Heros.Remove(hero);
                        i--;
                    }

                }

            }
        }

        public void AddHero(Hero hero)
        {
            Heros.Add(hero);
        }

        public void AddEnemy(Enemy enemy)
        {
            Enemies.Add(enemy);
        }

        private void EnemysDeath(Enemy enemy, Hero hero)
        {
            if (enemy.Health == 0)
            {
                hero.ReceiveVP(enemy);
                Enemies.Remove(enemy);
            }

        }
        private void HealHero(Hero hero)
        {
            if (hero.VictoryPoint == 5)
                hero.Cure();
        }

    }


}