namespace MicroRPG
{
    public class Item
    {
        public string Name {get; init;}
        public int Quantity {get; init;}

        public Item (string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }
    }
}
