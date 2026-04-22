// Import necessary classes for file handling and reading user input
import java.io.*;  // Import classes for input/output operations
import java.nio.file.*;  // Import classes for working with file paths
import java.util.Scanner;  // Import Scanner to read user input

// Class responsible for writing student data to the file
public class StudentProfileWrite {

    // Constructor that executes the writing logic when an object is created
    public StudentProfileWrite() {
        
        // Create a scanner object to read user input from the console
        Scanner sInput = new Scanner(System.in);

        // Define the path to the file where student data will be stored
        Path file = Paths.get("StudentProfile.txt");

        // Create a StringBuilder to build each student record before writing to the file
        StringBuilder studentProfilesString = new StringBuilder();

        // Define the delimiter that separates fields in the student profile (e.g., "#")
        String delimiter = "#";

        // Declare variables to store student details
        String name;  // Variable to store student's name
        double gpa;  // Variable to store student's GPA
        int studentId = 0;  // Variable to store student ID, initialized to 0
        String major;  // Variable to store student's major
        boolean isEnrolled;  // Variable to store whether the student is enrolled or not

        try {
            // Create an output stream to open the file and append new data to it
            OutputStream output = new BufferedOutputStream(
                    Files.newOutputStream(file, StandardOpenOption.CREATE, StandardOpenOption.APPEND));

            // Create a BufferedWriter to write to the file efficiently
            BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(output));

            // Ask the user for the student ID
            System.out.println("Enter the student Id: (-1 to quit entering students)");
            studentId = sInput.nextInt();  // Read the student ID
            sInput.nextLine();  // Consume the newline character after reading the ID

            // Loop to enter multiple student profiles until user types -1
            while (studentId != -1) {

                // Ask for the student's full name and store it
                System.out.println("Enter Full Name:");
                name = sInput.nextLine();

                // Ask for the student's GPA and store it
                System.out.println("Enter GPA:");
                gpa = sInput.nextDouble();  // Read the GPA as a double
                sInput.nextLine();  // Consume the newline after reading the GPA

                // Ask for the student's major and store it
                System.out.println("Enter major:");
                major = sInput.nextLine();

                // Ask if the student is currently enrolled and store the result
                System.out.println("Are you currently enrolled (True or False):");
                isEnrolled = sInput.nextBoolean();  // Read true or false
                sInput.nextLine();  // Consume the newline after reading the boolean value

                // Validate the input to ensure that GPA is between 0 and 4, and name is not empty
                if ((gpa >= 0.0 && gpa <= 4.0) && name != null && !name.isEmpty()) {

                    // Reset the StringBuilder to ensure we're starting with an empty string for the next student
                    studentProfilesString.setLength(0); 

                    // Build the student profile string with the student's details
                    studentProfilesString.append(studentId).append(delimiter);
                    studentProfilesString.append(name).append(delimiter);
                    studentProfilesString.append(gpa).append(delimiter);  // Add GPA to the string
                    studentProfilesString.append(major).append(delimiter);
                    studentProfilesString.append(isEnrolled);  // Add enrollment status

                    // Write the student profile string to the file
                    writer.write(studentProfilesString.toString(), 0, studentProfilesString.length());

                    // Write a new line after the record for the next student
                    writer.newLine();
                } else {
                    // Display an error message if input is invalid
                    System.out.println("Invalid input. Please enter the info again.\n");
                }

                // Ask for the next student ID (or exit if -1)
                System.out.println("Enter the student Id: (-1 to quit entering students)");
                studentId = sInput.nextInt();  // Update studentId to process the next student's data
                sInput.nextLine();  // Consume the newline character after reading the ID
            }

            // Close the BufferedWriter and the scanner when done
            writer.close();
            sInput.close();

        } catch(Exception e) {
            // If there's any error, print the error message
            System.out.println("Message: " + e.getMessage());
        }
    }
}