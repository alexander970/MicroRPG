namespace MicroRPG
{
    public class Bee : Enemy
    {
        private bool hasPoisonSting;

        public Bee(string name, int maxHealth, ConsoleColor color,bool hasPoisonSting) 
            : base(name, maxHealth, color,ArtAssets.Bee)
        {
            this.hasPoisonSting = hasPoisonSting;
        }
        public string StingerType
        {
            get
            {
                return hasPoisonSting ? "poison" : "sharp";
            }

        }

        public void Fly()
        {
            Console.BackgroundColor = this.Color;
            Console.Write($" {this.Name} ");
            Console.ResetColor();
            Console.WriteLine(" takes to the air!");
        }

        public void Sting()
        {
            Console.BackgroundColor = this.Color;
            Console.Write($" {this.Name} ");
            Console.ResetColor();
            Console.WriteLine($" lunges forward with their { this.StingerType } stinger!");
        }
    }
}
 