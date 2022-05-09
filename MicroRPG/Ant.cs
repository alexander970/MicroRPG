namespace MicroRPG
{
    public class Ant : Enemy
    {
        private readonly double chargeDistance;
        private Item? currentItem;
        public Ant(string name, int maxHealth, ConsoleColor color, double chargeDistance)
            :base(name,maxHealth,color,ArtAssets.Ant)

        {
            this.chargeDistance = chargeDistance;
        }

        private double ChargeDistance
        {
            get 
            { 
                return this.chargeDistance; 
            }
        }

        public void Charge()
        {
            Console.BackgroundColor = this.Color;
            Console.Write($" { this.Name } ");
            Console.ResetColor();
            Console.WriteLine($" charges swiftly forward { this.ChargeDistance } inches");

            if (this.currentItem != null)
            {
                Console.WriteLine($"They are carrying a {this.currentItem}.");
            }
        }

        public void Bite()
        {
            Console.BackgroundColor = this.Color;
            Console.Write($" { this.Name } ");
            Console.ResetColor();
            Console.WriteLine(" viciously chomps down!");
        }

        public void PickUpItem(Item item)
        {
            this.currentItem = item;
        }
    }
}
