class Player
{
    // auto property
    private int Inventorychest;
     public Room CurrentRoom { get; set; }
     // constructor
     public Player()
     {

        CurrentRoom = null;
     
     }

     public void PrintInventorychest()
    {
        Console.WriteLine("Inventory Contents:");
        foreach (var item in items)
        {
            Console.WriteLine($"- {item.Description} ({item.Weight} kg)");
        }
        Console.WriteLine($"Used: {UsedWeight()} / {maxWeight} kg");
        Console.WriteLine($"Remaining: {RemainingWeight()} kg\n");
    }
     
 }