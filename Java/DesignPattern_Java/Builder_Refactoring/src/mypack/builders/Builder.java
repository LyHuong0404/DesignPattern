package mypack.builders;


import mypack.cars.CarType;
import mypack.components.Engine;
import mypack.components.GPSNavigator;
import mypack.components.Transmission;
import mypack.components.TripComputer;

//Builder interface defines all possible ways to configure a product
public interface Builder {

	void setCarType(CarType type);
	void setSeats(int seats);
	void setEngine(Engine engine);
	void setTransmission(Transmission transmission);
	void setTripComputer(TripComputer tripComputer);
	void setGPSNavigator(GPSNavigator gpsNavigator);
	
}
