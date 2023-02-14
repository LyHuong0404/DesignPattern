public class DemoSingleThread
{
    public static void Main(string[] args)
    {
        Console.WriteLine("If you see the same value, then singleton was reused (yay!)" + "\n" +
                "If you see different values, then 2 singletons were created (booo!!)" + "\n\n" +
                "RESULT:" + "\n");
        Singleton singleton = Singleton.getInstance("FOO");
        Singleton anotherSingleton = Singleton.getInstance("BAR");
        Console.WriteLine(singleton.value);
        Console.WriteLine(anotherSingleton.value);
    }
}