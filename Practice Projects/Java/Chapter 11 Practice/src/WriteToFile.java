// Import the necessary classes for writing to a file
import java.io.*;

public class WriteToFile {

    // Main method - where the program starts
    public static void main(String[] args) {
        
        // Try block to safely handle file writing and catch any errors
        try (BufferedWriter writer = new BufferedWriter(new FileWriter("grades.txt"))) {
            
            // Write the first line to the file: name and grade
            writer.write("Eric, 95");

            // Move to a new line in the file
            writer.newLine();

            // Write the second line to the file: name and grade
            writer.write("Alex, 88");

            // File will be saved and closed automatically after the try block

        } catch (IOException e) {
            // If an error happens while writing, this will show the error message
            e.printStackTrace();
        }
    }
}
