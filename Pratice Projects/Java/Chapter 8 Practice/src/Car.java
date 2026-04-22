
public class Car 
{
	private int year;
    private String model;
    private String color;

    // Constructor to initialize Car object
    public Car(int yr, String m, String c) {
        year = yr;
        model = m;
        color = c;
    }

    // Method to display Car details
    public void display() {
        System.out.println("Car is a " + year + " " + color + " " + model);
    }
}
