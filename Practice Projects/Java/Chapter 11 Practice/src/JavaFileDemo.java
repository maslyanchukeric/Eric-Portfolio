// Import necessary classes for file handling and I/O operations
import java.io.*;
import java.nio.file.*;

public class JavaFileDemo {  // Main class

    public static void main(String[] args) {
        // Define the path to the file named "demo.txt" in the current directory
        Path file = Paths.get("demo.txt");

        // ==============================
        // SECTION 1: WRITE TO THE FILE
        // ==============================

        // Define the string that we want to write to the file
        String outputString = "ABCDEF\n";  // Adding a newline to separate entries
        // Convert the string into a byte array (since OutputStream writes bytes)
        byte[] data = outputString.getBytes();

        try {
            // Check if the file exists. If not, create it to prevent errors.
            if (!Files.exists(file)) {
                Files.createFile(file);  // Creates the file if it doesn't exist
                System.out.println("File 'demo.txt' was not found, so it was created.");
            }

            // Open an output stream in append mode using BufferedOutputStream
            OutputStream output = new BufferedOutputStream(
                Files.newOutputStream(file, StandardOpenOption.APPEND)
            );

            // Write the byte data to the file
            output.write(data);

            // Ensure all data is flushed (written out) from the buffer
            output.flush();

            // Close the output stream to free resources
            output.close();

            // Let the user know the writing was successful
            System.out.println("Successfully wrote to the file.");

        } catch (IOException e) {
            // Catch any file-related exception and display an error message
            System.out.println("ERROR writing to file: " + e.getMessage());
        }

        // ==============================
        // SECTION 2: READ FROM THE FILE
        // ==============================

        try {
            // Open an input stream to read from the file
            InputStream input = Files.newInputStream(file);

            // Wrap the input stream in a BufferedReader for easy line-by-line reading
            BufferedReader reader = new BufferedReader(new InputStreamReader(input));

            // Print a heading for the file contents
            System.out.println("\nContents of 'demo.txt':");

            // Declare a string to hold each line as we read it
            String line;

            // Read each line from the file until the end is reached (null)
            while ((line = reader.readLine()) != null) {
                // Print the line with a "->" arrow for clarity
                System.out.println("-> " + line);
            }

            // Close the reader to release file resources
            reader.close();

        } catch (IOException e) {
            // Catch and handle any error that occurs while reading from the file
            System.out.println("ERROR reading from file: " + e.getMessage());
        }
    }
}