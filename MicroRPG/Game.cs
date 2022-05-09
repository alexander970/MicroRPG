namespace MicroRPG
{
    public class Game
    {
        private Item leafNinjaStar;

        private Ant fireAuntie;
        private Ant hades;
        private Bee buzzBee;
        private Tiger tiger;

        public Game()
        {
            this.fireAuntie = new Ant("Fire Auntie", 100, ConsoleColor.Red, 3);

            this.leafNinjaStar = new Item("Leaf Ninja star", 10);
            this.hades = new Ant("Hades",200, ConsoleColor.Magenta, 6);
            this.hades.PickUpItem(this.leafNinjaStar);

            this.buzzBee = new Bee("BuzzBee", 75, ConsoleColor.DarkYellow, false);
            this.tiger = new Tiger("Tiger", 100, ConsoleColor.DarkGray);    
        }

        private void WaitForKey()
        {
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey(true);
        }

        public void Run()
        {
            Console.WriteLine("##### Micro RPG #####\n");
            
            this.fireAuntie.DisplayInfo();
            Console.WriteLine();
            this.fireAuntie.Charge();
            this.fireAuntie.Bite();
            Console.WriteLine();

            this.hades.DisplayInfo();
            Console.WriteLine();
            this.hades.Charge();
            this.hades.Bite();
            Console.WriteLine();

            this.buzzBee.DisplayInfo();
            Console.WriteLine();
            this.buzzBee.Fly();
            this.buzzBee.Sting();
            Console.WriteLine();

            this.tiger.DisplayInfo();
            Console.WriteLine();
            this.tiger.Roar();
            Console.WriteLine();

            this.WaitForKey();
        }
    }
}