var vendingMachine = new VendingMachine()
{
    Inventory = new List<Inventory>()
    {
        new Inventory()
        {
            ItemName = "Coca Cola",
            Price = 20,
            Index = 1
        },
        new Inventory()
       {
           ItemName = "Fanta",
           Price = 20,
            Index = 2
       },
        new Inventory()
       {
           ItemName = "Water",
           Price = 10,
            Index = 3
       },
       new Inventory()
       {
           ItemName = "Sandwich",
           Price = 28,
            Index = 4
       },
       new Inventory()
       {
           ItemName = "Snickers",
           Price = 13,
            Index = 5
       },
       new Inventory()
       {
           ItemName = "Chips",
           Price = 18,
            Index = 6
       },
       new Inventory()
       {
           ItemName = "WASA Sandwich",
           Price = 16,
            Index = 7
       },
    }
};

vendingMachine.Run();