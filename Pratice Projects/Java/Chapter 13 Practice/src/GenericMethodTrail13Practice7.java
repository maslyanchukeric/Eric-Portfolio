// Generic class MyBox<T> where T is a placeholder for any data type (like String, Integer, etc.)
class MyBox<T> {
    // This variable will hold a value of any type (T)
    private T value;

    // Method to set the value inside the box
    public void set(T value) {
        this.value = value;
    }

    // Method to get the value from the box
    public T get() {
        return value;
    }
}

// Main test class
public class GenericMethodTrail13Practice7 {

    // Generic method that can print an array of any type (T could be Integer, String, etc.)
    public static <T> void printArray(T[] array) {
        for (T item : array) {
            System.out.println(item + " ");  // Print each item followed by a space
        }
    }

    // Main method: program starts here
    public static void main(String[] args) {
        
        //Test the generic MyBox class using String type
        MyBox<String> b = new MyBox<>();  // Create a box that stores a String
        b.set("Hello, Eric!");            // Set a message into the box
        System.out.println(b.get());      // Get the message and print it

        //Test the generic printArray method using Integer array
        Integer[] nums = {1, 2, 3, 4};    // Create an array of integers
        printArray(nums);                // Call the generic method to print the array
    }
}
