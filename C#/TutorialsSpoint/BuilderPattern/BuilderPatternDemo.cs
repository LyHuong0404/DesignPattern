public class BuilderPatternDemo
{
    public static void Main(string[] args)
    {

        MealBuilder mealBuilder = new MealBuilder();

        Meal vegMeal = mealBuilder.prepareVegMeal();
        Console.WriteLine("Veg Meal");
        vegMeal.showItems();
        Console.WriteLine("Total Cost: " + vegMeal.getCost());

        Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
        Console.WriteLine("\n\nNon-Veg Meal");
        nonVegMeal.showItems();
        Console.WriteLine("Total Cost: " + nonVegMeal.getCost());
    }
}