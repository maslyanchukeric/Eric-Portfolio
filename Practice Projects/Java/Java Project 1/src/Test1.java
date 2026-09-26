//import Random and JOptionPane
import java.util.Random;
import javax.swing.JOptionPane;

public class Test1 {

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		//ask user to enter a number
		String userEntry = JOptionPane.showInputDialog(null, "Please hit capital Y to enter the Rock, Paper, Sicissors Shot game");
		
		//using a while loop to enter the game
		while(userEntry.equals("Y"))
		{
			//program creates a random number
			Random rand = new Random();
			
			//random number will be from 1-
			int num = rand.nextInt(3);
			
			//user enters  rock is 3, Scissors is 2, Paper is 1
			String choice;
			
			//this variable holds the users choice 
			int userNum = 0;
			
			
			//using a while loop to loop until user wins
			while(userNum != num)
			{
				//print the random number to beat the computer
				System.out.println("This is the random " + num);
				
				//user is asked to enter a number from 1-3. Rock is 3, Scissors is 2, Paper is 1
				choice = JOptionPane.showInputDialog(null, "Please enter a number from 1-3. Rock is 3, Scissors is 2, Paper is 1");
				
				//print the random number to beat the computer
				System.out.println("This is the random " + num);
				
				//choice is converted to a string 
				userNum = Integer.parseInt(choice);
				
				
				//print the user number to see what they enter
				System.out.println("This is the userNum " + userNum);
				
				//if rock and rock is chosen then a tie
				if(num == 3 && userNum == 3)
				{
					//if user chooses 3 for rock they Tie
					JOptionPane.showMessageDialog(null, "You Tied! You chose Rock!");		
				}
				//if rock and sicssors are chosen then rocks wins
				else if(num == 3 && userNum == 2)
				{
					//if user enters 2 they win
					JOptionPane.showMessageDialog(null, "You lose! You chose Sicssors");
				}
				else if(num == 3 && userNum == 1)
				{
					//if user enters 1 they lose
					JOptionPane.showMessageDialog(null, "You Won! You chose Paper");
				}
				
				if(num == 2 && userNum == 3)
				{
					//if user chooses 3 for rock they win
					JOptionPane.showMessageDialog(null, "You Won! You chose Rock");
						
				}
				else if(num == 2 && userNum == 2)
				{
					//if user chooses 2 for Scissors they tied
					JOptionPane.showMessageDialog(null, "You tied! You chose Sicssors");
				
				}
				else if(num == 2 && userNum == 1) 
				{
					//if user chooses paper the lose
					JOptionPane.showMessageDialog(null, "You lose! You chose Paper");
				}
				else if(num == 1 && userNum == 3)
				{
					//if user chooses 3 for rock they lose
					JOptionPane.showMessageDialog(null, "You lose! You chose Rock");	
				}
				else if(num == 1 && userNum == 2) 
				{
					//if user chooses 2 for scissors they lose
					JOptionPane.showMessageDialog(null, "You Won! You chose Sicssors");
				}
				else if(num == 1 && userNum == 1)
				{
					//if user chooses 1 for paper they tied
					JOptionPane.showMessageDialog(null, "You tied! You chose Paper");
				}
			}
		}
			//Update read (user is asked to enter the game again.
			JOptionPane.showInputDialog(null, "Would like to play Rock, Paper, Sicissors Shot Game again, please enter the number Y");
	}

}
