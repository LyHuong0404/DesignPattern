package mypack;

//Step 2: Create concrete classes extending the above class.

public class Square extends Shape{

	public Square(){
		type = "Square";
	}

	@Override
	void draw() {
		System.out.println("Inside Square::draw() method.");

	}

}
