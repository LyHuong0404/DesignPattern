public class Demo
{

    public static void Main(string[] args)
    {

        ShapeCache.loadCache();

        Shape clonedShape = ShapeCache.GetShape("1");
        Console.WriteLine("Shape : " + clonedShape.Type);

        Shape clonedShape2 = ShapeCache.GetShape("2");
        Console.WriteLine("Shape : " + clonedShape2.Type);

        Shape clonedShape3 = ShapeCache.GetShape("3");
        Console.WriteLine("Shape : " + clonedShape3.Type);
    }
}