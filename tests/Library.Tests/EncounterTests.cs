global using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using RoleplayGame;
namespace Library.Tests;

public class EncounterTests
{
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
    [Test]
    public void MyEncounter1vs1()
    {
        Hero myHero = new Hero("juana");
        myHero.AddItem("baston", 0, 50);
        Enemy myEnemy = new Enemy("lucia");
        myEnemy.AddItem("baston", 0, 20);

        Encounter newEncounter = new Encounter();

        newEncounter.AddHero(myHero);
        newEncounter.AddEnemy(myEnemy);

        newEncounter.DoEncounter();
        int expected = 0;
        Assert.That(expected, Is.EqualTo(myEnemy.Health));
    }

    [Test]
    public void MyEncounter3vs1()
    {
        Hero myHero = new Hero("juana");
        myHero.AddItem("baston", 0, 50);
        Enemy myEnemy = new Enemy("lucia");
        myEnemy.AddItem("baston", 0, 20);
        Enemy myEnemy2 = new Enemy("pepe");
        myEnemy.AddItem("baston", 0, 30);
        Enemy myEnemy3 = new Enemy("pedro");
        myEnemy.AddItem("baston", 0, 50);

        Encounter newEncounter = new Encounter();

        newEncounter.AddHero(myHero);
        newEncounter.AddEnemy(myEnemy);
        newEncounter.AddEnemy(myEnemy2);
        newEncounter.AddEnemy(myEnemy3);

        newEncounter.DoEncounter();
        int expected = 0;
        Assert.That(expected, Is.EqualTo(myHero.Health));
    }

    [Test]
    public void MyEncounter3vs2()
    {
        Hero myHero = new Hero("juana");
        myHero.AddItem("baston", 0, 50);
        Hero myHero2 = new Hero("chu");
        myHero2.AddItem("baston", 0, 50);
        Enemy myEnemy = new Enemy("lucia");
        myEnemy.AddItem("baston", 0, 20);
        Enemy myEnemy2 = new Enemy("pepe");
        myEnemy.AddItem("baston", 0, 30);
        Enemy myEnemy3 = new Enemy("pedro");
        myEnemy.AddItem("baston", 0, 50);

        Encounter newEncounter = new Encounter();

        newEncounter.AddHero(myHero);
        newEncounter.AddHero(myHero2);
        newEncounter.AddEnemy(myEnemy);
        newEncounter.AddEnemy(myEnemy2);
        newEncounter.AddEnemy(myEnemy3);

        newEncounter.DoEncounter();

        int expected = 0;
        Assert.That(expected, Is.EqualTo(newEncounter.Heros.Count));
    }
}