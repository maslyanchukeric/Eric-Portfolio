// Import the LinkedList class so we can use it to store strings in a list
import java.util.LinkedList;

// Main class
public class LinkedListTrail13Practice4 {

    // Main method: the program starts running here
    public static void main(String[] args) {

        // Create a LinkedList of Strings named 'linked'
        LinkedList<String> linked = new LinkedList<>();

        // Add elements to the list
        linked.add("One");        // Adds "One" to the end of the list
        linked.add("Two");        // Adds "Two" to the end of the list
        linked.addFirst("Zero");  // Adds "Zero" to the beginning of the list

        // Remove the last element from the list
        linked.removeLast();  // Removes "Two" from the end

        // Print the contents of the list
        System.out.println(linked);  // Expected output: [Zero, One]
    }
}
