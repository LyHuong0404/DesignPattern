public class Engine
{
    private double volume;
    private double mileage;
    private Boolean started;

    public Engine(double volume, double mileage)
    {
        this.volume = volume;
        this.mileage = mileage;
    }

    public void on()
    {
        started = true;
    }

    public void off()
    {
        started = false;
    }

    public Boolean isStarted()
    {
        return started;
    }

    public void go(double mileage)
    {
        if (started)
        {
            this.mileage += mileage;
        }
        else
        {
            Console.WriteLine("Cannot go(), you must start engine first!");
        }
    }

    public double getVolume()
    {
        return volume;
    }

    public double getMileage()
    {
        return mileage;
    }
}