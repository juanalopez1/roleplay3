using System.Collections.Generic;

namespace RoleplayGame;

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
                foreach (Enemy enemy in Enemies) // primer ataque de enemigos si hay un solo heroe
                {
                    Heros[0].Health -= enemy.AttackValue;

                    if (Heros[0].Health > 0)
                    {
                        enemy.Health -= Heros[0].AttackValue;

                        EnemysDeath(enemy, Heros[0]);
                        CureHero(Heros[0]);
                    }
                    if (Heros[0].Health < 0)
                        Heros.Remove(Heros[0]);

                }

            else if (Heros.Count > 1 && Enemies.Count > 1  // uno para cada uno (1 vs 1)
                && Heros.Count == Enemies.Count)
            {
                foreach (Enemy enemy in Enemies)
                {
                    foreach (Hero hero in Heros)
                    {
                        hero.Health -= enemy.AttackValue;

                        if (hero.Health > 0)
                        {
                            enemy.Health -= hero.AttackValue;
                            EnemysDeath(enemy, hero);
                            CureHero(hero);
                        }
                        if (hero.Health < 0)
                            Heros.Remove(hero);
                    }
                }
            }

            else if (Heros.Count < Enemies.Count)   // menos heroes que enemigos
            {
                for (int i = 0; i < Enemies.Count; i++)
                {
                    foreach (Enemy enemy in Enemies)
                    {
                        foreach (Hero hero in Heros)
                        {
                            hero.Health -= enemy.AttackValue;

                            if (hero.Health > 0)
                            {
                                enemy.Health -= hero.AttackValue;
                                EnemysDeath(enemy, hero);
                                CureHero(hero);
                            }
                            if (hero.Health < 0)
                                Heros.Remove(hero);
                        }
                    }
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
    private void CureHero(Hero hero)
    {
        if (hero.VictoryPoint == 5)
            hero.Cure();
    }

}
