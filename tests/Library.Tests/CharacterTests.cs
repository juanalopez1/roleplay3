global using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using RoleplayGame;
namespace Library.Tests;
public class CharacterTests
{
    [Test]
    public void CorrectValues()
    {
        Character myChar = new Character("juana");

        myChar.AddItem("pistola", 50, 50);

        int expected = 50;
        Assert.That(expected, Is.EqualTo(myChar.AttackValue));
        Assert.That(expected, Is.EqualTo(myChar.DefenseValue));
    }

    [Test]
    public void CorrectCure()
    {
        Character myChar = new Character("juana");

        int total = myChar.DefenseValue + myChar.Health;
        int lomato = myChar.Health - total;
        myChar.Cure();

        int expected = 100;
        Assert.That(expected, Is.EqualTo(myChar.Health));

    }

    [Test]
    public void CorrectReceiveAttack()
    {
        Character myChar = new Character("ju");
        Character secChar = new Character("pili");
        secChar.AddItem("hacha", 100, 100);

        myChar.ReceiveAttack(secChar.AttackValue);

        int expected = 0;
        Assert.That(expected, Is.EqualTo(myChar.Health));
    }
}