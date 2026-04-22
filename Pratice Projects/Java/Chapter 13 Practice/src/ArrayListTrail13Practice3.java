// Import the ArrayList class so we can use it to store double values
import java.util.ArrayList;

// Main class
public class ArrayListTrail13Practice3 {

    // Main method: the program starts running here
    public static void main(String[] args) {

        // Create an ArrayList that will store Double values (decimal numbers)
        ArrayList<Double> list = new ArrayList<>();

        // Add decimal values (doubles) to the ArrayList
        list.add(5.5);  // Add 5.5 to the list
        list.add(6.6);  // Add 6.6 to the list
        list.add(7.7);  // Add 7.7 to the list

        // Print the second item in the list
        // Remember: index starts at 0, so index 1 is the second item
        System.out.println("Second item: "  + list.get(1));  // Should print 6.6
    }
}