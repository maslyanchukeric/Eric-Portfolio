
public class CreateClassAndObjects {
    
    // Make the Car class static so main can use it
    static class Car {
        String color;
        int speed;
    }

    public static void main(String[] args) {
        Car myCar = new Car(); // Works now!
        myCar.color = "Red";
        myCar.speed = 120;

        System.out.println("My car is " + myCar.color + " and goes " + myCar.speed + " MPH.");
    }
}
