// Import the necessary classes to work with files
import java.io.*;

public class ReadRandomFiles {

    // Main method - where the program starts running
    public static void main(String[] args) {

        // Try block to open the random access file for reading only
        // "r" means read-only mode
        try (RandomAccessFile raf = new RandomAccessFile("students.dat", "r")) {

            // Move the file pointer to the beginning of the file (position 0)
            raf.seek(0);

            // Read the first student's name from the file (this must match how it was written)
            System.out.println("Name: " + raf.readUTF());

            // Read the first student's score (integer value right after name)
            System.out.println("Score: " + raf.readInt());

            // File pointer is now right after the first record
            // No need to seek again — it will automatically continue reading from where it left off

            // Read the second student's name
            System.out.println("Name: " + raf.readUTF());

            // Read the second student's score
            System.out.println("Score: " + raf.readInt());

            // After this, the file will close automatically because of try-with-resources

        } catch (IOException e) {
            // If any error happens (like file not found or reading issue), print the error
            e.printStackTrace();
        }
    }
}

