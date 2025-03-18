namespace ConsoleApp777
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Asus", 5, 1200, 16);
            notebook.Storage = 512;

            notebook.Sale();
            notebook.ShowFullData();
        }
    }
    class Product
    {
        public string Name;
        public string Description;
        public int Count;
        public bool IsStock;
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public void Sale()
        {
            if (!IsStock || Count <= 0)
            {
                Console.WriteLine("Məhsul yoxdur!");
            }
            else
            {
                Count--;
                if (Count == 0)
                {
                    IsStock = false;
                }
            }
        }
    }

    class Notebook : Product
    {
        private byte ram;
        public int Storage;

        public byte RAM
        {
            get { return ram; }
            set { ram = value; }
        }

        public Notebook(string name, int count, double price, byte ram)
        {
            Name = name;
            Count = count;
            Price = price;
            RAM = ram;
            IsStock = count > 0;
        }

        public void GetFullInfo()
        {
            Console.WriteLine($"Name: {Name}, Count: {Count}, Price: {Price}, RAM: {RAM}GB, Storage: {Storage}GB");
        }

        public void ShowFullData()
        {
            GetFullInfo();
        }
    }

}
