// Import the ArrayList class (used to create a resizable list of numbers)
import java.util.ArrayList;

// Import the List interface (defines behaviors like add, remove, get)
import java.util.List;

// Main class
public class ListInterfaceTrial13Practice2 {

    // Main method: this is where the program starts running
    public static void main(String[] args) {

        // Create a List of Integers called 'numbers'
        // ArrayList is being used to store numbers in order
        List<Integer> numbers = new ArrayList<>();

        // Add numbers to the list (in order)
        numbers.add(10);  // Adds 10 to the list
        numbers.add(20);  // Adds 20 to the list
        numbers.add(30);  // Adds 30 to the list

        // Add the number 15 at index 1 (so it goes between 10 and 20)
        numbers.add(1, 15);  // List becomes [10, 15, 20, 30]

        // Remove the number 30 from the list (by value, not by index)
        numbers.remove(Integer.valueOf(30));  // Removes the number 30

        // Print the entire list to see the current values
        System.out.println(numbers);  // Expected output: [10, 15, 20]
    }
}