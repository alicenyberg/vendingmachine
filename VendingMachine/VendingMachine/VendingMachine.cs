class VendingMachine
{
    public List<Inventory> Inventory { get; set; } 
    public List<string> Database { get; set; } = new List<string>();
    

        public VendingMachine() => Load();

        public void Load()
        {
            var filename = "/tmp/database.txt";

            if (File.Exists(filename))
                Database = File.ReadAllLines(filename).ToList();
        }

        public void Save()
        {
            var filename = "/tmp/database.txt";

            File.WriteAllLines(filename, Database);
        }

        public void Run()
        {
            
            Console.WriteLine("*** Welcome to the best vending machine!!!! ***");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("We offer: ");
            foreach (var item in Inventory)
                {
                    Console.WriteLine($"- {item.ItemName}, {item.Price}:-");
                }
            Console.WriteLine();
            Console.ResetColor();
        }

        public void Buy()
            {
                 

            }

        public string GetCommand()
        {
            while (true)
            {
                Console.Write("Write the name of the item you want to buy: ");

                var input = Console.ReadLine()!;

                
            }
        }
}


