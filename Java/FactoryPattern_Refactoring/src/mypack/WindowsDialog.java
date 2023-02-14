package mypack;

//One more concrete creator
public class WindowsDialog extends Dialog{

	@Override
	public Button createButton() {
		return new WindowsButton();
	}

}
