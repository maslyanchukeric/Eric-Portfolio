import java.util.Scanner;

public class BowlingTeamDemo2 
{

	public static void main(String[] args) 
	{
		String name;
		
		final int NUM_TEAM_MEMBERS = 4;
		
		final int NUM_TEAMS = 4;
		BowlingTeam[] teams = new BowlingTeam[NUM_TEAMS];
		
		//created a object for bowling team class
		BowlingTeam bowlTeam = new BowlingTeam();
		
		//creating a scanner object
		Scanner input = new Scanner(System.in);
		
		for(int j = 0; j < NUM_TEAMS; j++)
		 {
			teams[j] = new BowlingTeam();
		 
		
			//asked user to enter team name
			System.out.println("Enter team name >> ");
			name = input.nextLine();
		
			//setting the name in bowling team class
			teams[j].setTeamName(name);
		
			//loop thru the array of names 
			for(int i = 0; i < NUM_TEAM_MEMBERS ; i++)
			{
				//aske user to enter 4 names
				System.out.println("Enter team member's name");
				name = input.nextLine();
			
				//set the bowling members
				teams[j].setMembers(i, name);
			}
		 }
		
		for(int j = 0; j < NUM_TEAMS; j++)
		{
			//display the details of the bowling team
			System.out.println("\nMembers of team " + teams[j].getTeamName());
			
			//loop thru the array to print the names of the team
			for(int i = 0; i < NUM_TEAM_MEMBERS; i++) 
			{
				System.out.println(teams[j].getMembers(i) + " ");
				System.out.println();
			}
		}
	}
}
