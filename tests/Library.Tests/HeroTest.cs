global using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using RoleplayGame;
namespace Library.Tests;

public class HeroTests
{
    [Test]
    public void CorrectVP()
    {
        Dwarf dwarf = new Dwarf("Pepito");
        Titan titan = new Titan("titan");
        titan.VictoryPoint = 80;
        int expected = 0;

        dwarf.Attack(titan);

        Assert.That(expected, Is.EqualTo(titan.VictoryPoint));
    }
}