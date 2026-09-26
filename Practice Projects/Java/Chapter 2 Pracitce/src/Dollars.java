import java.util.*;
public class Dollars {

	public static void main(String[] args){
		/*
		 * write a program that allows the user to enter an integer number of dollars and calculate and display
		 * the convertions into current denominations like 20s, 10s, 5s, and 1s
		 */
		
		int usersNum;
		int hundredDollarBills;
		int fiftyDollarBills;
		int twentyDollarBills;
		int tenDollarBills;
		int fiveDollarBills;
		int oneDollarBills;
		
		//imported a scanner
		Scanner input = new Scanner(System.in);
		
		//user asked to enter amount of money
		System.out.println("Please enter a dollar amount: ");
		usersNum = input.nextInt();
		
		// Calculate how many $50 bills
		hundredDollarBills = usersNum / 100;
		usersNum = usersNum % 100; // Remaining amount after $100 bills
				
		// Calculate how many $50 bills
		fiftyDollarBills = usersNum /50;
		usersNum = usersNum % 50; // Remaining amount after $50 bills
		
		// Calculate how many $20 bills
        twentyDollarBills = usersNum / 20;
        usersNum = usersNum % 20; // Remaining amount after $20 bills

        // Calculate how many $10 bills
        tenDollarBills = usersNum / 10;
        usersNum = usersNum % 10; // Remaining amount after $10 bills

        // Calculate how many $5 bills
        fiveDollarBills = usersNum / 5;
        usersNum = usersNum % 5; // Remaining amount after $5 bills

        // Whatever is left are $1 bills
        oneDollarBills = usersNum;
        
        //displays the amount of Currency Denomiantion
		System.out.println("Currency Denominations: " + "\n" +
						   "100 Dollar Bills: " + hundredDollarBills + "\n"+
						   "50 Dollar Bills: " + fiftyDollarBills + "\n"+
						   "20 Dollar Bills: " + twentyDollarBills + "\n"+
				           "10 Dollar Bills: " + tenDollarBills + "\n" + 
				           "5 Dollar Bills: " + fiveDollarBills + "\n"+
				           "1 Dollar Bills: " + oneDollarBills + "\n");
	}

}
