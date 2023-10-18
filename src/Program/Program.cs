using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook("spellbook", 20, 20, 20);
            book.AddSpell(new Spell(50, 50));
            book.AddSpell(new Spell(30, 20));

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book);

            Dwarf gimli = new Dwarf("Gimli");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}");

            Hero myHero = new Hero("juana");
            myHero.AddItem("baston", 0, 50);
            Enemy myEnemy = new Enemy("lucia");
            myHero.AddItem("baston", 0, 20);

            Encounter newEncounter = new Encounter();

            newEncounter.AddHero(myHero);
            newEncounter.AddEnemy(myEnemy);

            newEncounter.DoEncounter();

        }
    }
}
