import java.util.Scanner;

public class BowlingTeamDemo4 
{
    public static void main(String[] args) 
    {
        final int NUM_TEAM_MEMBERS = 4;
        final int NUM_TEAMS = 4;
        BowlingTeam[] teams = new BowlingTeam[NUM_TEAMS];
        
        // ✅ Replace manual input with method call
        getTeamData(teams);
        
        // ✅ Display team members
        for (int j = 0; j < NUM_TEAMS; j++) 
        {
            System.out.println("\nMembers of team " + teams[j].getTeamName());
            for (int i = 0; i < NUM_TEAM_MEMBERS; i++) 
            {
                System.out.println(teams[j].getMembers(i) + " ");
            }
            System.out.println(); // Formatting
        }
        
        // ✅ Searching for a team
        Scanner input = new Scanner(System.in);
        System.out.println("Enter a team name to see its roster:");
        String name = input.nextLine();
        
        boolean found = false;
        for (int j = 0; j < teams.length; j++) 
        {
            if (name.equalsIgnoreCase(teams[j].getTeamName())) 
            {
                System.out.println("\nRoster for " + teams[j].getTeamName() + ":");
                for (int i = 0; i < NUM_TEAM_MEMBERS; i++) 
                {
                    System.out.println(teams[j].getMembers(i));
                }
                found = true;
                break;
            }
        }

        if (!found) 
        {
            System.out.println("❌ Team not found!");
        }
    }
    
    //Method to accept a bowling team array and get input
    public static void getTeamData(BowlingTeam[] teams)
    {
        final int NUM_TEAMS = 4;
        final int NUM_TEAM_MEMBERS = 4;
        Scanner input = new Scanner(System.in);
        
        for (int i = 0; i < NUM_TEAMS; i++) 
        {
            teams[i] = new BowlingTeam();
            System.out.println("Enter team name >> ");
            String name = input.nextLine();
            teams[i].setTeamName(name);

            for (int j = 0; j < NUM_TEAM_MEMBERS; j++) // ✅ Fix: Changed "i < NUM_TEAM_MEMBER" to "j < NUM_TEAM_MEMBER"
            {
                System.out.println("Enter team member's name >> ");
                name = input.nextLine();
                teams[i].setMembers(j, name); // ✅ Fix: Set member in the correct team index
            }
        }
    }
}

