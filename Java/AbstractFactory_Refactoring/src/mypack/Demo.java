package mypack;

import mypack.app.Application;
import mypack.factories.GUIFactory;
import mypack.factories.MacOSFactory;
import mypack.factories.WindowsFactory;

// Demo class. Everything comes together here.
public class Demo {

	public static Application configureApplication() {
		Application app;
		GUIFactory factory;
		String osName = System.getProperty("os.name").toLowerCase();
		if (osName.contains("mac")) {
			factory = new MacOSFactory();
		} else {
			factory = new WindowsFactory();
		}
		app = new Application(factory);
		return app;
	}

	public static void main(String[] args) {
		Application app = configureApplication();
		app.paint();
	}
}
