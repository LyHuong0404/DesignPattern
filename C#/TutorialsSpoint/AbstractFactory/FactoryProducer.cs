public class FactoryProducer
{
    public static AbstractFactory getFactory(Boolean rounded)
    {
        if (rounded)
        {
            return new RoundedShapeFactory();
        }
        else
        {
            return new ShapeFactory();
        }
    }
}