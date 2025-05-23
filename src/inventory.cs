class Inventory
{
    // fields
    private int maxWeight;
    private string UsedWeight;
    private string Weight;
    private Dictionary<string, Item> items;
    
    // constructor
    public Inventory(int maxWeight)
    {

     this.maxWeight = maxWeight;
     
     this.items = new Dictionary<string, Item>();
    
    }
    // methods
   public void  AddUsedWeight(string UsedWeight, Item item)
   {
    
    Weight.Add(UsedWeight, item);


   }
    public bool Put(string itemName, Item item)
     {
        if (UsedWeight() + item.Weight <= maxWeight)
        {
            items.Add(item);
            Console.WriteLine($"{item.Description} added to inventory.");
            return true;
        }
        else
        {
            Console.WriteLine($"Not enough space for {itemName}.");
            return false;
        }
    }

    public Item Used()
    {
        return items.Sum(i => i.Description);
    }

    public Item RemainingWeight()
    {
        return maxWeight - UsedWeight();
    }

   

}
    
    