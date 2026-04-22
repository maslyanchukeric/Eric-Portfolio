import javax.swing.JOptionPane;

//SavingsAccount class inherits from BankAccount
public class SavingsAccount extends BankAccount
{
	//Creating feild for storing the interest rate
	private double interestRate;
	
	//default Constructor initializing interest rate to 0
	public SavingsAccount()
	{
		interestRate = 0.0;
	}
	
	/*
	 *  Parameterized Constructor
	 *  accountNumber - Unique account ID
	 *  ownerName - Name of the account holder
	 *  email - Email of the account holder
	 *  phoneNumber - Contact number of the account holder
	 *  balance - Initial account balance
	 *  interestRate - Interest rate in percentage
	 */
	
	public SavingsAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance, double interestRate)
	{
		// Calls the constructor of the parent class (BankAccount)
		super(accountNumber, ownerName, email, phoneNumber, balance);
		this.interestRate = interestRate;
	}

	//get interestRate returns interestRate
	public double getInterestRate()
	{
		return interestRate;
	}
	
	//set interestRate parameter is a interest rate
	public void setInterestRate(double interestRate)
	{
		this.interestRate = interestRate;
	}
	
	//method to calculate the interestRate returns the amount earned in dollars
	public double calculateInterest(double interestRate)
	{
		return balance * (interestRate/100);
	}
	
	
	//method to Displays account details, interest rate, and calculated interest earned
	public void displayInterestRateAndInterestEarned()
	{
		
		//Display interest rate percentage
		JOptionPane.showMessageDialog(null, "Interest Rate: " + interestRate + " %\n" +
				"Interest Earned: " + calculateInterest(interestRate) + " $");
		
		
	}
}