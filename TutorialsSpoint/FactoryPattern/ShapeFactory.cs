 public class ShapeFactory {

    public Shape getShape(string shapeType)
    {
    
        
        if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
        {
            return new Circle();

        }
       else if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
        {
            return new Rectangle();

        }
        else if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
        {
            return new Square();
        }
        return new Square();
     
    }
    
 }