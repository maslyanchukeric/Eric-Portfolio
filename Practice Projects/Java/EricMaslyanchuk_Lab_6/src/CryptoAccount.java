//CryptoAccount class inherits from BankAccount

import javax.swing.JOptionPane;

public class CryptoAccount extends BankAccount
{
	//feilds that hold crypto balance and crypto type
	private double cryptoBalance;
	private String cryptoType;
	
	//default constructor
	public CryptoAccount()
	{
		//default constructor initializing cryptoBalance to 0
		cryptoBalance = 0.0;
		
		//default constructor initializing cryptoType to empty
		cryptoType = "";
	}
	
	/*
	 *  Parameterized Constructor
	 *  accountNumber - Unique account ID
	 *  ownerName - Name of the account holder
	 *  email - Email of the account holder
	 *  phoneNumber - Contact number of the account holder
	 *  balance - Initial account balance
	 *  cryptoBalance - holder enters crpyto balance
	 *  cryptoType - holder enter the type of crypto
	 */
	public CryptoAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance, double cryptoBalance, String cryptoType)
	{
		// Calls the constructor of the parent class (BankAccount)
		super(accountNumber, ownerName, email, phoneNumber, balance);
		
		this.cryptoBalance = cryptoBalance;
		this.cryptoType = cryptoType;
	}
	
	//get the crypto balance
	public double getCryptoBalance()
	{
		return cryptoBalance;
	}
	
	//get the crypto type
	public String getCryptoType()
	{
		return cryptoType;
		
	}
	
	//set Crypto Balance
	public void setCryptoBalance(double cryptoBalance)
	{
		if(cryptoBalance >= 0) 
		{
			//cryptoBalance is set as investment
			this.cryptoBalance = cryptoBalance;
			
			//shows message for holder 
			JOptionPane.showMessageDialog(null, "New Crypto Balance: $" + this.cryptoBalance);
		}
		else
		{
			//shows message for holder 
			JOptionPane.showMessageDialog(null, "Invalid Crypto Balance can't be below 0");
		}
		
	}
	
	//set the crypto type
	public void setCryptoType(String cryptoType)
	{
		this.cryptoType = cryptoType;
	}
	
	//display the Crypto
	public void displayCrypto()
	{
		//displays all the bank account info 
    	displayAccountInfo();
    	
    	JOptionPane.showMessageDialog(null, "Crypto Balance: " + getCryptoBalance() +
				"\nCrypto Type: " + getCryptoType());
	}	
}
