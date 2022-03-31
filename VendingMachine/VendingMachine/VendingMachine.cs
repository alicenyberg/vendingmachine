class VendingMachine
{
    public List<Inventory> Inventory { get; set; }
    public List<string> Database { get; set; } = new List<string>();
    public User User { get; set; }


    //public VendingMachine() => Load();

    //public void Load()
    //{
    //    var filename = "/tmp/database.txt";

    //    if (File.Exists(filename))
    //        Database = File.ReadAllLines(filename).ToList();
    //}

    //public void Save()
    //{
    //    var filename = "/tmp/database.txt";

    //    File.WriteAllLines(filename, Database);
    //}

    public void AddPerson()
    {
        Console.WriteLine("*** Welcome the best vending machine!!!! ***");
        Console.Write("Hi! What is your name? ");

        var name = "";

        while (name == "")
        {
            name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You need to write your name");

            }
        }

        Console.Write("How much money do you have? ");
        var money = Console.ReadLine();
        var moneyToInt = Convert.ToInt32(money);

        User = new User()
        {
            Name = name,
            Money = moneyToInt
        };
    }

    public void DisplayItems()
    {

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("We offer: ");
        foreach (var item in Inventory)
        {
            Console.WriteLine($"{item.Index} - {item.ItemName}, {item.Price}:-");
        }
    }

    public void Run()
    {

        AddPerson();

        DisplayItems();
        Console.WriteLine();
        Console.ResetColor();
        GetItem();
        while (true)
        {
          
            Console.WriteLine("Do you want to buy anything else? Yes/No");
            var answer = Console.ReadLine();
            if (answer == "Yes")
            {
                Console.WriteLine($"You have {User.Money}:- left.");
                DisplayItems();
                Console.WriteLine();
                Console.ResetColor();
                GetItem();
            }
            else if (answer == "No")
            {
                Console.WriteLine($"Thank you for shopping at the best vending machine! You have {User.Money}:- left to spend in the machine.");
                return;
            } else
            {
                Console.WriteLine("Please type Yes or No");
            }
        }
        
    }


    public void GetItem()
    {

        Console.Write("If you want to buy anything, type the number: ");
        var answer = Console.ReadLine();
        var answerToInt = Convert.ToInt32(answer);

        foreach (var item in Inventory)
        {
            if (answerToInt == item.Index && User.Money >= item.Price)
            {
                User.Money -= item.Price;
                Console.WriteLine($"You bought {item.ItemName}");
   
                return;
            }
            else if (answerToInt == item.Index && User.Money < item.Price)
            {
                Console.WriteLine("You can't afford this right know, pick something cheaper");
                return;

            }

        }
        Console.WriteLine("That item does not exist, choose another one!");
        return;
    }
}


