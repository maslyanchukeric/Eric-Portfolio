// Import necessary Java libraries
import java.nio.file.*;                      // For working with files and paths
import java.io.*;                            // For input/output streams
import java.nio.channels.FileChannel;        // For random-access file operations
import java.nio.ByteBuffer;                  // For reading/writing bytes
import static java.nio.file.StandardOpenOption.*; // For file open options like CREATE, WRITE
import java.util.Scanner;                    // For user input
import java.text.*;                          // For number formatting

public class CreateFilesBasedOnStates {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in); // Scanner to read user input

        // Define file paths for in-state and out-of-state customer files
        Path inStateFile = Paths.get("C:\\Users\\masly\\OneDrive\\Desktop\\School\\Semester 5\\CPT 236\\Chapter 11 Practice\\InStateCusts.txt");
        Path outOfStateFile = Paths.get("C:\\Users\\masly\\OneDrive\\Desktop\\School\\Semester 5\\CPT 236\\Chapter 11 Practice\\OutOfStateCusts.txt");

        // Setup formatting rules
        final String ID_FORMAT = "000";            // 3-digit ID format
        final String NAME_FORMAT = "      ";       // 6-character name field
        final int NAME_LENGTH = NAME_FORMAT.length(); // Get the fixed length for name
        final String HOME_STATE = "WI";            // Define home state (Wisconsin)
        final String BALANCE_FORMAT = "0000.0";    // Format for balance
        String delimiter = ",";                    // Field separator
        String s = ID_FORMAT + delimiter + NAME_FORMAT + delimiter + HOME_STATE + delimiter + BALANCE_FORMAT + System.getProperty("line.separator");
        final int RECSIZE = s.length();            // Total length of one record

        FileChannel fcIn = null;   // File channel for in-state customers
        FileChannel fcOut = null;  // File channel for out-of-state customers

        String idString;       // To hold input account number as string
        int id;                // To hold parsed ID number
        String name;           // To hold name
        String state;          // To hold entered state
        double balance;        // To hold balance
        final String QUIT = "999"; // Quit flag

        // Create empty files pre-filled with default records
        createEmptyFile(inStateFile, s);
        createEmptyFile(outOfStateFile, s);

        try {
            // Open both files with write permission (create if they don’t exist)
            fcIn = (FileChannel) Files.newByteChannel(inStateFile, CREATE, WRITE);
            fcOut = (FileChannel) Files.newByteChannel(outOfStateFile, CREATE, WRITE);

            // Prompt user for input
            System.out.println("Enter customer account number >>");
            idString = input.nextLine(); // Read ID as string

            // Continue loop until user enters 999
            while (!idString.equals(QUIT)) {
                id = Integer.parseInt(idString); // Convert ID string to int

                // Prompt for customer name
                System.out.println("Enter name for customer >>");
                name = input.nextLine();
                StringBuilder sb = new StringBuilder(name); // Pad name to fixed size
                sb.setLength(NAME_LENGTH);
                name = sb.toString();

                // Prompt for state
                System.out.println("Enter state >>");
                state = input.nextLine();

                // Prompt for balance
                System.out.println("Enter balance >>");
                balance = input.nextDouble();
                input.nextLine(); // Clear newline

                DecimalFormat df = new DecimalFormat(BALANCE_FORMAT); // Format balance

                // Build formatted record string
                s = idString + delimiter + name + delimiter + state + delimiter + df.format(balance) + System.getProperty("line.separator");

                // Convert record to bytes and wrap in ByteBuffer
                byte data[] = s.getBytes();
                ByteBuffer buffer = ByteBuffer.wrap(data);

                // Write to correct file based on state
                if (state.equals(HOME_STATE)) {
                    fcIn.position(id * RECSIZE); // Calculate write position
                    fcIn.write(buffer);          // Write to in-state file
                } else {
                    fcOut.position(id * RECSIZE); // Write to out-of-state file
                    fcOut.write(buffer);
                }

                // Prompt for next customer
                System.out.println("Enter next customer account number or " + QUIT + " to quit >>");
                idString = input.nextLine();
            }

            // Close file channels
            fcIn.close();
            fcOut.close();
        } catch (Exception e) {
            System.out.println("Error message " + e);
        }
    }

    // Method to pre-fill a file with 1000 default records
    public static void createEmptyFile(Path file, String s) {
        final int NUMRECS = 1000;

        try {
            OutputStream outputStr = new BufferedOutputStream(Files.newOutputStream(file, CREATE));
            BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(outputStr));

            for (int count = 0; count < NUMRECS; ++count) {
                writer.write(s, 0, s.length()); // Write default record
            }

            writer.close(); // Close writer
        } catch (Exception e) {
            System.out.println("Error message: " + e);
        }
    }
}