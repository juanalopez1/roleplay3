namespace Program
{
    using System;
    using RoleplayGame;
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
            Hero myHero2 = new Hero("chu");
            myHero2.AddItem("baston", 0, 50);
            Enemy myEnemy = new Enemy("lucia");
            myEnemy.AddItem("baston", 0, 20);
            Enemy myEnemy2 = new Enemy("pepe");
            myEnemy.AddItem("baston", 0, 20);
            Enemy myEnemy3 = new Enemy("pedro");
            myEnemy.AddItem("baston", 0, 20);

            Encounter newEncounter = new Encounter();

            newEncounter.AddHero(myHero);
            newEncounter.AddHero(myHero2);
            newEncounter.AddEnemy(myEnemy);
            newEncounter.AddEnemy(myEnemy2);
            newEncounter.AddEnemy(myEnemy3);

            newEncounter.DoEncounter();
        }
    }
}
