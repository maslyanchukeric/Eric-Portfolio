// Import the required classes for working with files
import java.io.*;

public class WriteAtSpecificPosition {

    // Main method - where the program starts
    public static void main(String[] args) {

        // Try block to safely open the file and catch any file-related errors
        // "rw" means the file is opened for both reading and writing
        try (RandomAccessFile raf = new RandomAccessFile("students.dat", "rw")) {

            // Position 0 - First record
            // Move the file pointer to the beginning of the file
            raf.seek(0);

            // Write the first student's name as a string in UTF format
            raf.writeUTF("Eric");

            // Write Eric's grade (an integer) right after the name
            raf.writeInt(95);

            // Position ~ (name is stored as 2-byte length + each char + 4 bytes for int)
            // Move the file pointer to the current end of the file so the next record doesn't overwrite the previous one
            raf.seek(raf.getFilePointer());  // getFilePointer() gives the exact position after the last write

            // Write the second student's name
            raf.writeUTF("Lily");

            // Write Lily's grade
            raf.writeInt(88);

            // File automatically closes when try block ends

        } catch (IOException e) {
            // If an error occurs while working with the file, print out the error
            e.printStackTrace();
        }
    }
}