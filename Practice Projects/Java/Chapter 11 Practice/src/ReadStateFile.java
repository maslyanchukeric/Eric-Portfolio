import java.nio.file.*;                         // File handling
import java.io.*;                               // Input/output streams
import java.nio.file.attribute.*;               // For file attributes
import static java.nio.file.StandardOpenOption.*; // File open options
import java.nio.ByteBuffer;                     // For reading raw bytes
import java.nio.channels.FileChannel;           // For random access
import java.util.Scanner;                       // For user input

public class ReadStateFile {
    public static void main(String[] args) {
        Scanner kb = new Scanner(System.in); // Scanner to get user input
        String fileName;

        // Prompt for file name (user will type: InStateCusts.txt or OutOfStateCusts.txt)
        System.out.print("Enter name of file to use >> ");
        fileName = kb.nextLine();

        // Build full file path
        fileName = "C:\\Users\\masly\\OneDrive\\Desktop\\School\\Semester 5\\CPT 236\\Chapter 11 Practice\\" + fileName;
        Path file = Paths.get(fileName);

        // Define record format details
        final String ID_FORMAT = "000";
        final String NAME_FORMAT = " ";
        final int NAME_LENGTH = NAME_FORMAT.length();
        final String HOME_STATE = "WI";
        final String BALANCE_FORMAT = "0000.00";
        String delimiter = ",";

        // Build dummy record to calculate RECSIZE
        String s = ID_FORMAT + delimiter + NAME_FORMAT + delimiter + HOME_STATE + delimiter + BALANCE_FORMAT + System.getProperty("line.separator");
        final int RECSIZE = s.length();

        byte data[] = s.getBytes();       // Byte array to hold a record
        final String EMPTY_ACCT = "000";  // Used to filter out default records
        String[] array = new String[4];   // For splitting each record
        double balance;
        double total = 0;                 // Running total of all balances

        try {
            // Display file creation time and size
            BasicFileAttributes attr = Files.readAttributes(file, BasicFileAttributes.class);
            System.out.println("\nAttributes of the file:");
            System.out.println("Creation time " + attr.creationTime());
            System.out.println("Size " + attr.size());
        } catch (IOException e) {
            System.out.println("IO Exception");
        }

        try {
            // Open file for reading line by line
            InputStream iStream = new BufferedInputStream(Files.newInputStream(file));
            BufferedReader reader = new BufferedReader(new InputStreamReader(iStream));

            System.out.println("\nAll non-default records:\n");
            s = reader.readLine(); // Read first line

            while (s != null) {
                array = s.split(delimiter); // Split the line into fields

                // Only process if it's not a default record
                if (!array[0].equals(EMPTY_ACCT)) {
                    balance = Double.parseDouble(array[3]);
                    System.out.println("ID #" + array[0] + " " + array[1] + array[2] + " $" + array[3]);
                    total += balance;
                }
                s = reader.readLine(); // Read next line
            }

            System.out.println("Total of all balances is $" + total);
            reader.close(); // Close reader
        } catch (Exception e) {
            System.out.println("Message: " + e);
        }

        try {
            // Prompt to seek specific account number
            FileChannel fc = (FileChannel) Files.newByteChannel(file, READ);
            ByteBuffer buffer = ByteBuffer.wrap(data);

            int findAcct;
            System.out.print("\nEnter account to seek >> ");
            findAcct = kb.nextInt();

            // Position the file pointer and read specific record
            fc.position(findAcct * RECSIZE);
            fc.read(buffer);
            s = new String(data); // Convert bytes to string
            System.out.println("Desired record: " + s);
        } catch (Exception e) {
            System.out.println("Message: " + e);
        }
    }
}