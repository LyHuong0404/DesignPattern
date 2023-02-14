package mypack;

//Get the only object from the singleton class.
public class SingletonPatternDemo {

	 public static void main(String[] args) {

	      //illegal construct: trái phép
	      //Compile Time Error: The constructor SingleObject() is not visible
	      //SingleObject object = new SingleObject();

	      //Get the only object available
	      SingleObject object = SingleObject.getInstance();

	      //show the message
	      object.showMessage();
	   }
}
