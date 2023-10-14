global using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using RoleplayGame;
namespace Library.Tests;

public class EncounterTests
{
    [TestCase]
    public void MyEncounter()
    {
        Assert.Pass();
    }

    public void CorrectAdd()
    {
        Hero myHero = new Hero("juana");
        Enemy myEnemy = new Enemy("lucia");

        Encounter newEncounter = new Encounter();

        newEncounter.AddHero(myHero);
        newEncounter.AddEnemy(myEnemy);

        int expected = 1;
        Assert.That(expected, Is.EqualTo(newEncounter.Enemies.Count));
        Assert.That(expected, Is.EqualTo(newEncounter.Heros.Count));
    }
}