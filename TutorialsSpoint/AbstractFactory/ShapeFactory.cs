 class ShapeFactory : AbstractFactory
    {

        internal override Shape getShape(String shapeType)
        {
            if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
            {

                return new Rectangle();

            }
            if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
            {

                return new Square();
            }
            return new Square();
        }
    }