public class RoundedShapeFactory : AbstractFactory
{

    internal override Shape getShape(String shapeType)
    {
        if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
        {
            return new RoundedRectangle();
        }
        else if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
        {
            return new RoundedSquare();
        }
        return new RoundedSquare();
    }
}