public class MileConversions {

    public static void main(String[] args) {
        // Declare named constants for conversion
        final int INCHES_PER_MILE = 63360;
        final int FEET_PER_MILE = 5280;
        final int YARDS_PER_MILE = 1760;

        // Declare a variable to store the number of miles
        double miles = 2.5;  // You can change this value

        // Calculate equivalent distances
        double inches = miles * INCHES_PER_MILE;
        double feet = miles * FEET_PER_MILE;
        double yards = miles * YARDS_PER_MILE;

        // Display results with explanatory text
        System.out.println(miles + " mile(s) is equivalent to:");
        System.out.println(inches + " inches");
        System.out.println(feet + " feet");
        System.out.println(yards + " yards");
    }
}
