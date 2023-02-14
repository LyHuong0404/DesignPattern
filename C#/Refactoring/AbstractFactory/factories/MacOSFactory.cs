public class MacOSFactory : GUIFactory
{

    public Button createButton()
    {
        return new MacOSButton();
    }


    public Checkbox createCheckbox()
    {
        return new MacOSCheckbox();
    }
}