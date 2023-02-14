public class Meal
{
    private List<Item> items = new List<Item>();

    public void addItem(Item item)
    {
        items.Add(item);
    }

    public float getCost()
    {
        float cost = 0.0f;

        foreach (Item item in items)
        {
            cost += item.price();
        }
        return cost;
    }

    public void showItems()
    {

        foreach (Item item in items)
        {
            Console.WriteLine("Item : " + item.name());
            Console.WriteLine(", Packing : " + item.packing().pack());
            Console.WriteLine(", Price : " + item.price());
        }
    }
}