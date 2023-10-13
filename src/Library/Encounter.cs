using System.Collections.Generic;

namespace RoleplayGame;

public abstract class Encounter
{
    public List<Hero> heros = new List<Hero>();

    public List<Enemy> enemies = new List<Enemy>();
    public void DoEncounter()
    {
        while (heros.Count != 0 || enemies.Count != 0)
        {
            if (heros.Count == 1)
                foreach (Enemy enemy in enemies) // primer ataque de enemigos si hay un solo heroe
                {
                    heros[0].Health -= enemy.AttackValue;
                    enemy.Health -= heros[0].AttackValue;

                    if (enemy.Health == 0)
                        heros[0].ReceiveVP(enemy);

                    if (heros[0].VictoryPoint == 5)
                        heros[0].Cure();

                    if (heros[0].Health < 0)
                        heros.Remove(heros[0]);

                    if (enemy.Health < 0)
                        enemies.Remove(enemy);
                }
            else if (heros.Count > 1 && enemies.Count > 1  // 
                && heros.Count == enemies.Count)
            {
                foreach (Enemy enemy in enemies)
                {
                    foreach (Hero hero in heros)
                    {
                        hero.Health -= enemy.AttackValue;
                        enemy.Health -= hero.AttackValue;
                        if (enemy.Health == 0)
                            heros[0].ReceiveVP(enemy);
                        if (heros[0].VictoryPoint == 5)
                            heros[0].Cure();
                    }
                }
            }
            else if (heros.Count < enemies.Count)
            {
                for (int i = 0; i < enemies.Count; i++)
                {
                    foreach (Enemy enemy in enemies)
                    {
                        foreach (Hero hero in heros)
                        {
                            hero.Health -= enemy.AttackValue;
                        }
                    }
                }
            }




        }
    }

    private void EnemyDeath(Enemy enemy, Hero hero)
    {
        if (enemy.Health == 0)
            hero.ReceiveVP(enemy);
    }

}
