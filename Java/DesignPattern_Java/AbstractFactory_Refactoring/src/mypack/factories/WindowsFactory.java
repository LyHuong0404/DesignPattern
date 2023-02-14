package mypack.factories;

import mypack.buttons.Button;
import mypack.buttons.WindowsButton;
import mypack.checkboxes.Checkbox;
import mypack.checkboxes.WindowsCheckbox;

//Concrete factory (Windows)
public class WindowsFactory implements GUIFactory{

	@Override
	public Button createButton() {
		return new WindowsButton();
	}

	@Override
	public Checkbox createCheckbox() {
		return new WindowsCheckbox();
	}

}
