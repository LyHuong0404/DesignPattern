package mypack.factories;

import mypack.buttons.Button;
import mypack.checkboxes.Checkbox;

// Abstract factory
public interface GUIFactory {
	Button createButton();
	Checkbox createCheckbox();
	    
}
