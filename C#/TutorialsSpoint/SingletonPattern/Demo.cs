public class Demo
{
    public static void Main(string[] args)
    {

        //Get the only object available
        SingletonPattern singlePattern = SingletonPattern.GetSinglePattern();
        singlePattern.showMessage();
    }
}