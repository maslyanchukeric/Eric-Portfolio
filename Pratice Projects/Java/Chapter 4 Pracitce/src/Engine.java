
public class Engine 
{
	public void start()
	{
		System.out.println("Engine Starts.");
	}

	public class Car
	{
		Engine engine = new Engine(); //Composition
		
		public void StartCar() {
			engine.start();//using another object inside
		}
	}
}
