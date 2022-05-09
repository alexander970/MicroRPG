namespace MicroRPG
{
    public class Tiger:Enemy
    {
        public Tiger(string name, int maxHealth, ConsoleColor color) 
            : base(name, maxHealth, color, ArtAssets.Tiger)
        {
        }

        public void Roar()
        {
            Console.BackgroundColor = this.Color;
            Console.Write($" {this.Name} ");
            Console.ResetColor();
            Console.WriteLine(" roars ferociously");
        }
    }
}
