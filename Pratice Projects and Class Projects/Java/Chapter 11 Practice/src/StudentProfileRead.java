// Import necessary classes for file handling
import java.io.*;  // Import classes for input/output operations
import java.nio.file.*;  // Import classes for working with file paths

// Class responsible for reading student data from the file
public class StudentProfileRead {

    // Constructor that handles reading the file when the object is created
    public StudentProfileRead() {

        // Define the path to the file we want to read
        Path file = Paths.get("StudentProfile.txt");

        // Variable to hold each line of the file while reading
        String studentProfilesString = "";
        // Define the delimiter that separates fields in the student profile (e.g., "#")
        String delimiter = "#";

        // Declare an array to store the individual profile data
        String[] profileArray = new String[5];
        String name;
        double gpa;
        int studentId = 0;
        String major;
        boolean isEnrolled;

        try {
            // Open the file for reading
            InputStream input = new BufferedInputStream(Files.newInputStream(file));

            // Create a BufferedReader to read data from the file
            BufferedReader reader = new BufferedReader(new InputStreamReader(input));

            // Read the first line (priming read)
            studentProfilesString = reader.readLine();

            // Loop until we've read all lines in the file
            while(studentProfilesString != null) {

                // Split the current line into fields based on the delimiter
                profileArray = studentProfilesString.split(delimiter);

                // Check that the profile contains the correct number of fields (5)
                if (profileArray.length == 5) {
                    // Parse each field and store them in the respective variables
                    studentId = Integer.parseInt(profileArray[0]);
                    name = profileArray[1];
                    gpa = Double.parseDouble(profileArray[2]);
                    major = profileArray[3];
                    isEnrolled = Boolean.parseBoolean(profileArray[4]);

                    // Display the student details on the console
                    System.out.println("Student ID: " + studentId + " Name: " + name + " GPA: " + gpa);
                    System.out.println("Major: " + major + " Is Enrolled: " + isEnrolled);
                } else {
                    // Skip malformed lines that don't have the correct number of fields
                    System.out.println("Skipping invalid record: " + studentProfilesString);
                }

                // Read the next line from the file
                studentProfilesString = reader.readLine();
            }

            // Close the reader when done reading
            reader.close();

        } catch(Exception e) {
            // If there's any error, print the error message
            System.out.println("Message: " + e.getMessage());
        } finally {
            // Display a message when exiting the program
            System.out.println("Exiting Program");
        }
    }
}