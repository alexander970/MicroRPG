namespace MicroRPG
{
    public class Enemy
    {
        
        private readonly string name;
        private readonly int maxHealth;
        private readonly ConsoleColor color;
        private readonly string textArt;

        private int health;
        public Enemy(string name, int maxHealth, ConsoleColor color, string textArt)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            this.color = color;
            this.health = maxHealth;
            this.textArt = textArt;
        }

       
        protected string Name
        {
            get 
            { 
                return this.name; 
            }
        }
        protected int MaxHealth
        {
            get
            {
                return this.maxHealth;
            }
        }

        protected int Health
        {
            get
            {
                return this.health;
            }
        }

        protected ConsoleColor Color
        {
            get
            {
                return this.color;
            }
        }

        protected string TextArt
        {
            get
            {
                return this.textArt;
            }
        }

        public void DisplayInfo()
        {
            Console.BackgroundColor = this.Color;
            Console.Write($"---{this.Name}---");
            Console.ResetColor();

            Console.ForegroundColor = this.Color;
            Console.WriteLine($"\n{ this.TextArt }\n");
            Console.WriteLine($"Max Health:{ this.MaxHealth }");
            Console.WriteLine($"Health:{ this.Health }");
            Console.WriteLine("---");
            Console.ResetColor();
        }
    }
}
