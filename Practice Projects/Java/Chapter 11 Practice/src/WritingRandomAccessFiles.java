// Import necessary classes for file handling
import java.io.*;

public class WritingRandomAccessFiles {

    // Main method - where the program starts running
    public static void main(String[] args) {

        // Try block to handle file operations safely and catch errors if something goes wrong
        // "rw" means we are opening the file for both reading and writing
        try (RandomAccessFile raf = new RandomAccessFile("student.dat", "rw")) {

            // Write the first student's name as a string (UTF format)
            raf.writeUTF("Eric");

            // Write Eric's score (an integer) right after his name
            raf.writeInt(95);

            // Write the second student's name
            raf.writeUTF("Jane");

            // Write Jane's score
            raf.writeInt(87);

            // Once the try block ends, the file is automatically closed

        } catch (IOException e) {
            // If there's any error while writing to the file, print the error message
            e.printStackTrace();
        }
    }
}
