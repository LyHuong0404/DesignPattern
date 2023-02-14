package mypack.factories;

import mypack.buttons.Button;
import mypack.buttons.MacOSButton;
import mypack.checkboxes.Checkbox;
import mypack.checkboxes.MacOSCheckbox;

//WindowsFactory
public class MacOSFactory implements GUIFactory{

	@Override
	public Button createButton() {
		return new MacOSButton();
	}

	@Override
	public Checkbox createCheckbox() {
		return new MacOSCheckbox();
	}

}
