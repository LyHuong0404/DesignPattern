using Prototype_Refactoring.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            List<Shape> shapesCopy = new List<Shape>();
            Circle circle = new Circle();
            circle.x = 10;
            circle.y = 20;
            circle.radius = 15;
            circle.color = "red";
            shapes.Add(circle);

            Circle anotherCircle = circle.clone() as Circle;
            shapes.Add(anotherCircle);

            Rectangle rectangle = new Rectangle();
            rectangle.width = 10;
            rectangle.height = 20;
            rectangle.color = "blue";
            shapes.Add(rectangle);

            cloneAndCompare(shapes, shapesCopy);

            Console.ReadLine();
        }

        private static void cloneAndCompare(List<Shape> shapes, List<Shape> shapesCopy)
        {
            foreach (Shape shape in shapes)
            {
                shapesCopy.Add(shape.clone());
            }

            for (int i = 0; i < shapesCopy.Count; i++)
            {
                if (shapes.ElementAt(i) != shapesCopy.ElementAt(i))
                {
                    Console.WriteLine(i + " : Shapes are different objects (yay!)");
                    if (shapes.ElementAt(i).Equals(shapesCopy.ElementAt(i)))
                    {
                        Console.WriteLine(i + " : And they are identical (yay!)");
                    }
                    else
                    {
                        Console.WriteLine(i + " : But they are not identical (booo!)");
                    }
                }
                else
                {
                    Console.WriteLine(i + " : Shape objects are the same (booo!)");
                }
            }
        }
       
    }

}

