using System;
using System.Threading;

public class DemoMultiThread
{
    public static void Main(string[] args)
    {
        Console.WriteLine("If you see the same value, then singleton was reused (yay!)" + "\n" +
                "If you see different values, then 2 singletons were created (booo!!)" + "\n\n" +
                "RESULT:" + "\n");
        Thread threadFoo = new Thread(ThreadFoo);
        Thread threadBar = new Thread(new ThreadBar());
        threadFoo.Start();
        threadBar.Start();
    }

    class ThreadFoo : ThreadStart
    {

        public override void run()
        {
            Singleton singleton = Singleton.getInstance("FOO");
            Console.WriteLine(singleton.value);
        }
    }

    class ThreadBar
    {

        public void run()
        {
            Singleton singleton = Singleton.getInstance("BAR");
            Console.WriteLine(singleton.value);
        }
    }
}