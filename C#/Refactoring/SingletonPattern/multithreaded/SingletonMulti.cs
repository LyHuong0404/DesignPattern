public sealed class SingletonMulti {
    private static SingletonMulti instance;
    public String value;

    private SingletonMulti(String value) {
        // The following code emulates slow initialization.
        try {
            Thread.Sleep(1000);
        } catch (ThreadInterruptedException ex) {
             Console.WriteLine(ex.Message);
        }
        this.value = value;
    }

    public static SingletonMulti getInstance(string value) {
        if (instance == null) {
            instance = new SingletonMulti(value);
        }
        return instance;
    }
}