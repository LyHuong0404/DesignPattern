package mypack.builders;

import mypack.cars.CarType;
import mypack.cars.Manual;
import mypack.components.Engine;
import mypack.components.GPSNavigator;
import mypack.components.Transmission;
import mypack.components.TripComputer;

//Builder of a car manual
public class CarManualBuilder implements Builder{

	private CarType type;
	private int seats;
	private Engine engine;
	private Transmission transmission;
	private TripComputer tripComputer;
	private GPSNavigator gpsNavigator;
	
	
	public Manual getResult() {
		return new Manual(type, seats, engine, transmission, tripComputer, gpsNavigator);
	}


	@Override
	public void setCarType(CarType type) {
		this.type = type;
		
	}


	@Override
	public void setSeats(int seats) {
		this.seats = seats;
		
	}


	@Override
	public void setEngine(Engine engine) {
		this.engine = engine;
		
	}


	@Override
	public void setTransmission(Transmission transmission) {
		this.transmission = transmission;
		
	}


	@Override
	public void setTripComputer(TripComputer tripComputer) {
		this.tripComputer = tripComputer;
		
	}


	@Override
	public void setGPSNavigator(GPSNavigator gpsNavigator) {
		this.gpsNavigator = gpsNavigator;
		
	}


}
