public abstract class ColdDrink : Item
{

    public Packing packing()
    {
        return new Bottle();
    }
    public String name()
    {
        return "ColdDrinkName";
    }

    public abstract float price();
}