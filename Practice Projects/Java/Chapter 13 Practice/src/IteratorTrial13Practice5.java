// Import the ArrayList class so we can use a dynamic list
import java.util.ArrayList;

// Import the List interface, which defines list behavior
import java.util.List;

// Import the Iterator interface to loop through elements one-by-one
import java.util.Iterator;

public class IteratorTrial13Practice5 {

    // Main method: this is where the program starts running
    public static void main(String[] args) {

        // Create a List of Strings called 'fruits' using an ArrayList
        List<String> fruits = new ArrayList<>();

        // Add some fruit names to the list
        fruits.add("Apple");   // Add "Apple"
        fruits.add("Banana");  // Add "Banana"
        fruits.add("Cherry");  // Add "Cherry"

        // Create an Iterator to go through the list one item at a time
        Iterator<String> it = fruits.iterator();

        // While the iterator still has items to look at
        while (it.hasNext()) {
            String fruit = it.next();       // Get the next item from the list
            System.out.println(fruit);      // Print that item
        }
    }
}