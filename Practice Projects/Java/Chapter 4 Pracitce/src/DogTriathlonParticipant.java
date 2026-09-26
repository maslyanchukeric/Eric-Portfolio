// Define the DogTriathlonParticipant class
public class DogTriathlonParticipant
{
    private final int NUM_EVENTS; // Should be final, initialized in constructor
    private static int totalCumulativeScore = 0; // Shared among all instances
    private String name;
    private int obedienceScore;
    private int confirmationScore;
    private int agilityScore;
    private int total;
    private double avg;

    // Constructor calculates the total score
    public DogTriathlonParticipant(String name, int numEvents, int score1, int score2, int score3) {
        this.name = name;
        this.NUM_EVENTS = numEvents; // Initialize final variable

        obedienceScore = score1;
        confirmationScore = score2;
        agilityScore = score3;

        total = obedienceScore + confirmationScore + agilityScore;
        avg = (double) total / NUM_EVENTS;

        totalCumulativeScore += total; // Add to the cumulative score
    }

    // Method to display the data for each participant
    public void display() 
    {
        System.out.println(name + " participated in " + NUM_EVENTS + " event(s) and has an average score of " + avg);
        System.out.println(name + " has a total score of " + total + ", bringing the total cumulative score to " + totalCumulativeScore);
        System.out.println("---------------------------------------------------");
    }
}
