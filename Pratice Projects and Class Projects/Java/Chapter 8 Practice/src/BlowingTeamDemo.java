import java.util.*;
public class BlowingTeamDemo 
{

	public static void main(String[] args) 
	{
		String name;
		int x;
		final int NUM_TEAM_MEMBERS = 4;
		
		//creating a scanner object
		Scanner input = new Scanner(System.in);
		
		//created a object for bowling team class
		BowlingTeam bowlTeam = new BowlingTeam();
		
		//asked user to enter team name
		System.out.println("Enter team name >> ");
		name = input.nextLine();
		
		//setting the name in bowling team class
		bowlTeam.setTeamName(name);
		
		//loop thru the array of names 
		for(int i = 0; i < NUM_TEAM_MEMBERS ; i++)
		{
			//aske user to enter 4 names
			System.out.println("Enter team member's name");
			name = input.nextLine();
			
			//set the bowling members
			bowlTeam.setMembers(i, name);
		}
		
		//display the details of the bowling team
		System.out.println("\nMembers of team " + bowlTeam.getTeamName());
		
		//loop thru the array to print the names of the team
		for(int i = 0; i < NUM_TEAM_MEMBERS; i++) 
		{
			System.out.println(bowlTeam.getMembers(i) + " ");
			System.out.println();
		}
		
	}

}
