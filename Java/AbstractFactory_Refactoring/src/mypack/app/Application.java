package mypack.app;

import mypack.buttons.Button;
import mypack.checkboxes.Checkbox;
import mypack.factories.GUIFactory;

public class Application {

	private Button button;
	private Checkbox checkbox;
	
	public Application(GUIFactory factory) {
		button = factory.createButton();
		checkbox = factory.createCheckbox();
	}
	
	public void paint() {
		button.paint();
		checkbox.paint();
	}
}
