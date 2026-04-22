import javax.swing.JOptionPane;

public class BankAccount 
{
	private String accountNumber;
	private String ownerName;
	private String email;
	private String phoneNumber;
	protected double balance;
	
	//Default Constructor
	public BankAccount()
	{
		accountNumber = "";
		ownerName = "";
		email = "";
		phoneNumber = "";
		balance = 0.0;
	}
	
	// Constructor
    public BankAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance) 
    {
        this.accountNumber = accountNumber;
        this.ownerName = ownerName;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.balance = balance;
    }
    //get account Number
    public String getAccountNumber()
    {
    	return accountNumber;
    }
    //get owner name
    public String getOwnerName()
    {
    	return ownerName;
    }
    //get email
    public String getEmail()
    {
    	return email;
    }
    //get phonenumber
    public String getPhoneNumber()
    {
    	return phoneNumber;
    }
    //get balance
    public double getBalance()
    {
    	return balance;
    }
    
    
    //set account Number
    public void setAccountNumber(String accountNumber)
    {
    	this.accountNumber = accountNumber;
    }
    //get owner name
    public void setOwnerName(String ownerNumber)
    {
    	this.ownerName = ownerNumber;
    }
    //get email
    public void setEmail(String email)
    {
    	 this.email = email;
    }
    //get phonenumber
    public void setPhoneNumber(String phoneNumber)
    {
    	this.phoneNumber = phoneNumber;
    }
    
  
  //deposit method 
    public void deposit(double amount) 
    {
        if (amount > 0) {
            balance += amount;
            JOptionPane.showMessageDialog(null, "Deposit successful. New balance: $" + balance);
        } 
        else 
        {
            JOptionPane.showMessageDialog(null, "Invalid deposit amount!");
        }
    }
    
    //withdraw method
    public void withDraw(double amount)
    {
    	if(amount > 0 && amount <= balance)
    	{
    		balance -= amount;
    		JOptionPane.showMessageDialog(null, "WithDraw Successfull. New balance: " + balance);
    	}
    	else
    	{
    		JOptionPane.showMessageDialog(null, "Invaild amount");
    	}
    }
    //display account info 
    public void displayAccountInfo()
    {
    	JOptionPane.showMessageDialog(null, "Account Number: " + this.accountNumber + 
    										"\n Owner Name: " + this.ownerName + 
    										"\n Email: " + this.email + 
    										"\n Phone Number: " + this.phoneNumber + 
    										"\n Balance : " + this.balance);
    	
    }
}