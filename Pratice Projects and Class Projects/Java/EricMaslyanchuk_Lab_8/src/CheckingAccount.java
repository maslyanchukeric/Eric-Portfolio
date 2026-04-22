import javax.swing.JOptionPane;

//checkingAccount class inherits from BankAccount
public class CheckingAccount extends BankAccount
{
	//class field for storing over draft limit 
	private double overDraftLimit; 
	
	//default constructor initializing over draft limit to 0
	public CheckingAccount()
	{
		overDraftLimit = 0.0;
	}
	
	/*
	 *  Parameterized Constructor
	 *  accountNumber - Unique account ID
	 *  ownerName - Name of the account holder
	 *  email - Email of the account holder
	 *  phoneNumber - Contact number of the account holder
	 *  balance - Initial account balance
	 *  overDraftLimit - limits the amount of money holder can withdraw
	 */
	public CheckingAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance, double overDraftLimit)
	{
		// Calls the constructor of the parent class (BankAccount)
		super(accountNumber, ownerName, email, phoneNumber, balance);
		//the class overDraft = to the parameter in the constructor
		this.overDraftLimit = overDraftLimit;
	}
	
	//get overDraftLimit returns overDraftLimit
	public double getOverDraftLimit()
	{
		return overDraftLimit;
	}
	
	//set overDraftLimit that has a parameter 
	public void setOverDraftLimit(double overDraftLimit)
	{
		this.overDraftLimit = overDraftLimit;
	}
	
	
	
	// Withdraw method with overdraft limit check
    @Override	
    public void withDraw(double amount)
    {
    	double maxWithDrawal = amount + overDraftLimit;
    	
    	if(amount > 0 && amount <= maxWithDrawal)
    	{
    		balance -= amount;
    		JOptionPane.showMessageDialog(null, "WithDraw Successfull. New balance: " + balance);
    	}
    	else
    	{
    		JOptionPane.showMessageDialog(null, "Invaild amount");
    	}
    	
    }
    
    public void displayOverDraftLimit()
    {
        // Calculate total available funds (balance + overdraft limit)
        double totalAvailable = balance + overDraftLimit;
        
        // Display both the overdraft limit and total available amount
        JOptionPane.showMessageDialog(null, 
            "Overdraft Limit: $" + overDraftLimit + 
            "\nTotal Available $" + totalAvailable);
    }
}
