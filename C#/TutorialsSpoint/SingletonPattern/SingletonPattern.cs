public class SingletonPattern
    {
        private static SingletonPattern singletonPattern = new SingletonPattern();

        private SingletonPattern() { }

        public static SingletonPattern GetSinglePattern()
        {
            return singletonPattern;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello Wolrd!");
        }
    }