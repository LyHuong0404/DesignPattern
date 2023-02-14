package mypack;

public class AbstractFactoryPatternDemo {

	public static void main(String[] args) {
		
		AbstractFactory shapeFactory = FactoryProducer.getFactory(false);
		//get an object of Shape Rectangle
		Shape shape1 = shapeFactory.getShape("RECTANGLE");
		shape1.draw();
		
		//get an object of Shape Square 
		Shape shape2 = shapeFactory.getShape("SQUARE");
		shape2.draw();
		
		//get shape factory
		AbstractFactory shapeFactory1 = FactoryProducer.getFactory(true);
		
		//get an object of Shape Rectangle
		Shape shape3 = shapeFactory1.getShape("RECTANGLE");
		shape3.draw();
		
		//get an object of Shape Square 
		Shape shape4 = shapeFactory1.getShape("SQUARE");
		shape4.draw();

	}
}
