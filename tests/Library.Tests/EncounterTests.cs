global using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using RoleplayGame;
namespace Library.Tests;

public class EncounterTests
{
    [TestCase]
    public void MyEncounter1vs1()
    {
        Hero myHero = new Hero("juana");
        myHero.AddItem("baston", 0, 50);
        Enemy myEnemy = new Enemy("lucia");
        myHero.AddItem("baston", 0, 20);

        Encounter newEncounter = new Encounter();

        newEncounter.AddHero(myHero);
        newEncounter.AddEnemy(myEnemy);

        newEncounter.DoEncounter();

        int expected = 0;
        Assert.That(expected, Is.EqualTo(newEncounter.Enemies.Count));
        Assert.That(expected, Is.EqualTo(newEncounter.Heros.Count));
    }

    [Test]
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