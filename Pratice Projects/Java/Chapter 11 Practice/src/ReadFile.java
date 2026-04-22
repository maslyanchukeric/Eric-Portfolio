// Import the necessary classes for reading files
import java.io.*;

public class ReadFile {

    // Main method - where the program starts
    public static void main(String[] args) {
        
        // Try block to handle file reading and catch any errors
        try (BufferedReader reader = new BufferedReader(new FileReader("grades.txt"))) {
            
            // Create a variable to store each line we read from the file
            String line;

            // Loop through the file, reading one line at a time until we reach the end
            while ((line = reader.readLine()) != null) {
                // Print the line we just read, with "Read: " in front of it
                // Using println instead of print to move to a new line after each line
                System.out.println("Read: " + line);
            }

        } catch (IOException e) {
            // If an error happens while opening or reading the file, print the error
            e.printStackTrace();
        }
    }
}
