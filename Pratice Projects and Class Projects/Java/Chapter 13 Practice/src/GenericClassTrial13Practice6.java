// Generic Box class using type parameter <T>
class Box<T> {
    // This variable will hold a value of type T (like String, Integer, etc.)
    private T value;

    // This method sets the value inside the box
    public void set(T value) {
        this.value = value;
    }

    // This method gets the value from the box
    public T get() {
        return value;
    }
}

// Test class with the main method
public class GenericClassTrial13Practice6 {

    // Main method: this is where the program starts running
    public static void main(String[] args) {
        // Create a Box that holds a String value
        Box<String> b = new Box<>();

        // Set a String value into the box
        b.set("Hello, Eric!");

        // Get and print the value from the box
        System.out.println(b.get());  // Output should be: Hello, Eric!
    }
}