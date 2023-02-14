public class WindowsFactory : GUIFactory
{
    public Button createButton()
    {
        return new WindowsButton();
    }


    public Checkbox createCheckbox()
    {
        return new WindowsCheckbox();
    }
}