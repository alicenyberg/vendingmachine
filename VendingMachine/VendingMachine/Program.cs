var vendingMachine = new VendingMachine()
{
    Inventory = new List<Inventory>()
    {
        new Inventory()
        {
            ItemName = "Coca Cola",
            Price = 20
        },
        new Inventory()
       {
           ItemName = "Fanta",
           Price = 20
       },
        new Inventory()
       {
           ItemName = "Water",
           Price = 10
       },
       new Inventory()
       {
           ItemName = "Sandwich",
           Price = 28
       },
       new Inventory()
       {
           ItemName = "Snickers",
           Price = 13
       },
       new Inventory()
       {
           ItemName = "Chips",
           Price = 18
       },
       new Inventory()
       {
           ItemName = "WASA Sandwich",
           Price = 16
       },
    }
};


//vendingMachine.InventoryInformation();

vendingMachine.Run();