namespace RoleplayGame
{
    using System.Collections.Generic;

    public class Hero : Character
    {
        public string Name { get; set; }
        private List<Item> items = new List<Item>();

        public Hero(string name) : base(name)
        {
            this.Name = name;
        }

        // IMagicalCharacter wizard = new Hero()

        public void ReceiveVP(Enemy enemy)
        {
            VictoryPoint += enemy.VictoryPoint;
            enemy.VictoryPoint = 0;
        }

    }
}