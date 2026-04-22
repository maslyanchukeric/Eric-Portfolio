// Import the ArrayList class (resizable array) from java.util package
import java.util.ArrayList;

// Import the Collection interface from java.util package
import java.util.Collection;

// Main class
public class CollectionInterfaceTrail13Practice1 {

    // Main method: where the program starts
    public static void main(String[] args) {

        // Create a Collection of Strings called 'names'
        // We're using ArrayList (a type of Collection) to store name strings
        Collection<String> names = new ArrayList<>();

        // Add some names into the collection
        names.add("Eric");  // Add "Eric" to the list
        names.add("John");  // Add "John" to the list
        names.add("Mia");   // Add "Mia" to the list

        // Loop through each item (name) in the collection and print it
        for (String name : names) {
            System.out.println(name);  // Print each name in the collection
        }
    }
}
