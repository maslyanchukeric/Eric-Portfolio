//import JOptionPane
import javax.swing.JOptionPane;

public class BankManagmentSystem 
{
	//add the Jframe
	
	
	//create an array of bankaccounts
	private static BankAccount[] bankAccounts = new BankAccount[5];
	private static int bankCount = 0;	
	
	//creating the 
	MutualFundAccount investmentAccount1 = new MutualFundAccount();
	public static void main(String[] args) 
	{
		BankManagmentSystem bankSystem = new BankManagmentSystem();
		
		//Create some bankacounts
		
		String userEntry = null;//holds the user entry 
		String staying = "No";//holds users option on exiting the program
		
		
		
		while(staying.equalsIgnoreCase("No")) 
		{
		    userEntry = bankMenu();
		    
		    if(userEntry == null) break;

		    int choice = Integer.parseInt(userEntry);

		    switch(choice) 
		    {
		        case 1:
		            CreateBankAccount();
		            break;
		        case 2:
		            SavingsAccount();
		            break;
		        case 3:
		            CheckingAccount();
		            break;
		        case 4:
		            MutualFundAccount();
		            break;
		        case 5:
		            CryptoAccount();
		            break;
		        case 6:
		            despoit();
		            break;
		        case 7:
		            withDraw();
		            break;
		        case 8:
		            viewAllBankInfo();
		            break;
		        case 9: 
		            exitBankingManagmentSystem();
		            staying = "Yes";  // Ensure exit
		            break;
		    }

		    staying = JOptionPane.showInputDialog(null, "Enter Yes to leave or No to stay!");
		}	
	}
	
	private static String bankMenu() 
	{
	    return JOptionPane.showInputDialog(null, "Welcome to Summit Crest Bank\n" + 
	            "*************************\n" +
	            "1. Create Account\n" +
	            "2. Create Savings Account\n" +
	            "3. Create Checking Account\n" +
	            "4. Create Mutual Fund Account\n" +
	            "5. Create Crypto Account\n" +
	            "6. Deposit\n" + 
	            "7. Withdraw\n" + 
	            "8. View Account Info\n" +
	            "9. Exit\n" + 
	            "**************************\n" +
	            "Enter a number 1 - 9");
	}

	//method for Creating a BankAccount
	private static void CreateBankAccount() 
	{
		//checks if array if full
		if(bankCount >= bankAccounts.length)
		{
			//error pops up for holder say that the array is full 
			JOptionPane.showMessageDialog(null, "Can not add any Bank Accounts. Due to Capactiy being Full");
			return;
		}
		
		//holder is asked for account number
		String accountNumber;
		accountNumber = JOptionPane.showInputDialog(null, "Create Bank Account Number");
		
		//check to make sure the account are digits
		if (!isValidAccountNumber(accountNumber)) 
		{
	        JOptionPane.showMessageDialog(null, "Invalid Account Number! Please enter digits only.");
	        return; // Exit if invalid
	    }
				
		//holder is asked for name
		String ownerName;
		ownerName = JOptionPane.showInputDialog(null, "Enter your full Name: ");
				
		//holder is asked for eamil
		String email;
		email = JOptionPane.showInputDialog(null, "Enter your email: ");
	    if (!email.contains("@") || !email.endsWith(".com")) 
	    {
	    	//error will show up to tell the user that they enter the email wrong
	        JOptionPane.showMessageDialog(null, "Invalid email! Please enter a valid email (must contain '@' and end with '.com').");
	        return; //exit the method if email is invaild
	    }
				
	    //holder is asked for phone number
	  	String phoneNumber= JOptionPane.showInputDialog(null, "Enter your phoneNumber: ");
	  	if(phoneNumber.length() < 10 || !isNumeric(phoneNumber))
	  	{
	  		//error will show up to tell the user that they enter the phone number wrong
	  		JOptionPane.showMessageDialog(null, "Invalid phone number! Please enter exactly 10 digits.");
	  		return; //exit the method if phone number is invaild
	  		
	  	}	
	  	
		//holder is asked for balance
		String moneybalance;
		moneybalance = JOptionPane.showInputDialog(null, "Enter your Balance: ");
		double balance = Double.parseDouble(moneybalance); //convert moneybalance to double balance
	
		//store Mutual fund account into array
		bankAccounts[bankCount] = new BankAccount(accountNumber, ownerName, email, phoneNumber, balance);
				
		//counts the amount of bank accounts created
		bankCount ++;	
		
		JOptionPane.showMessageDialog(null, "Bank Account ADDED SUCCESSFULLY");
	}
	
	//method for Creating a Savings Account
	private static void SavingsAccount() 
	{
	    // Check if array is full
	    if (bankCount >= bankAccounts.length)
	    {
	        JOptionPane.showMessageDialog(null, "Cannot add any more Bank Accounts. Capacity is full.");
	        return; // Exit method
	    }

	    // Get user input for Savings Account details
	    String accountNumber = JOptionPane.showInputDialog(null, "Create Savings Account Number:");
	    
	    //check to make sure the account are digits
	  	if (!isValidAccountNumber(accountNumber)) 
	  	{
	  		JOptionPane.showMessageDialog(null, "Invalid Account Number! Please enter digits only.");
	  	    return; // Exit if invalid
	  	}

	    String ownerName = JOptionPane.showInputDialog(null, "Enter your Full Name:");

	    String email = JOptionPane.showInputDialog(null, "Enter your Email:");
	    if (!email.contains("@") || !email.endsWith(".com")) 
	    {
	    	//error will shop up to tell the user that they enter the email wrong
	        JOptionPane.showMessageDialog(null, "Invalid email! Please enter a valid email (must contain '@' and end with '.com').");
	        return; //exit the method if email is invaild
	    }

	    //holder is asked for phone number
	    String phoneNumber= JOptionPane.showInputDialog(null, "Enter your phoneNumber: ");
	    if(phoneNumber.length() < 10 || !isNumeric(phoneNumber))
	    {
	    	//error will shop up to tell the user that they enter the phone number wrong
	    	JOptionPane.showMessageDialog(null, "Invalid phone number! Please enter exactly 10 digits.");
	    	return; //exit the method if phone number is invaild
	    }
	  
	    String moneyBalance = JOptionPane.showInputDialog(null, "Enter your Balance:");
	    double balance = Double.parseDouble(moneyBalance);

	    //Get the interest rate from user
	    String interestRateInput = JOptionPane.showInputDialog(null, "Enter Interest Rate (in %):");
	    double interestRate = Double.parseDouble(interestRateInput);

	    // Create SavingsAccount object
	    SavingsAccount newSavings = new SavingsAccount(accountNumber, ownerName, email, phoneNumber, balance, interestRate);

	    //Call calculateInterest() **AFTER** creating the object
	    double interest = newSavings.calculateInterest();

	    //Display the interest earned
	    JOptionPane.showMessageDialog(null, "Interest Earned: $" + interest);

	    //Store the SavingsAccount in the array
	    bankAccounts[bankCount] = newSavings;

	    //Increment the bank account counter
	    bankCount++;

	    //message to user that Saving account is added
	    JOptionPane.showMessageDialog(null, "Savings Account ADDED SUCCESSFULLY");
	}
	
	//method to create MutualFundAcccount
	public static void MutualFundAccount()
	{
		//checks if array if full
		if(bankCount >= bankAccounts.length)
		{
			//error pops up for holder say that the array is full 
			JOptionPane.showMessageDialog(null, "Can not add any Bank Accounts. Due to Capactiy being Full");
			return;
		}
		
		//holder is asked for account number
		String accountNumber = JOptionPane.showInputDialog(null, "Create Mutual Fund Account Number");
		//check to make sure the account are digits
		if (!isValidAccountNumber(accountNumber)) 
		{
			JOptionPane.showMessageDialog(null, "Invalid Account Number! Please enter digits only.");
			return; // Exit if invalid
		}
		
		//holder is asked for name
		String ownerName = JOptionPane.showInputDialog(null, "Enter your full Name: ");
		
		//holder is asked for eamil
		String email = JOptionPane.showInputDialog(null, "Enter your email: ");
	    if (!email.contains("@") || !email.endsWith(".com")) 
	    {
	    	//error will shop up to tell the user that they enter the email wrong
	        JOptionPane.showMessageDialog(null, "Invalid email! Please enter a valid email (must contain '@' and end with '.com').");
	        return; //exit the method if email is invaild
	    }
		
	    //holder is asked for phone number
		String phoneNumber= JOptionPane.showInputDialog(null, "Enter your phoneNumber: ");
		if(phoneNumber.length() < 10 || !isNumeric(phoneNumber))
		{
			//error will shop up to tell the user that they enter the phone number wrong
			JOptionPane.showMessageDialog(null, "Invalid phone number! Please enter exactly 10 digits.");
			return; //exit the method if phone number is invaild
		}
		//holder is asked for balance
		String moneybalance = JOptionPane.showInputDialog(null, "Enter your Balance: ");
		double balance = Double.parseDouble(moneybalance); //convert moneybalance to double balance
		
		//holder is asked for investmentBalance
		String investment = JOptionPane.showInputDialog(null, "Enter your amount you want to invest: ");
		double investmentBalance = Double.parseDouble(investment); //convert moneybalance to double balance
		
		//store Mutual fund account into array
		bankAccounts[bankCount] = new MutualFundAccount(accountNumber, ownerName, email, phoneNumber, balance, investmentBalance);
		
		//counts the amount of bank accounts created
		bankCount ++;	
		
		//message to user that Mutual Fund Account account is added
		JOptionPane.showMessageDialog(null, "Mutual Fund Account ADDED SUCCESSFULLY");
	}
	
	private static void CheckingAccount() 
	{	
		//checks if array if full
		if(bankCount >= bankAccounts.length)
		{
			//error pops up for holder say that the array is full 
			JOptionPane.showMessageDialog(null, "Can not add any Bank Accounts. Due to Capactiy being Full");
			return;
		}
		
		//holder is asked for account number
		String accountNumber = JOptionPane.showInputDialog(null, "Create Mutual Fund Account Number");
		//check to make sure the account are digits
		if (!isValidAccountNumber(accountNumber)) 
		{
			JOptionPane.showMessageDialog(null, "Invalid Account Number! Please enter digits only.");
			return; // Exit if invalid
		}

		//holder is asked for name
		String ownerName = JOptionPane.showInputDialog(null, "Enter your full Name: ");
		
		//holder is asked for eamil
		String email = JOptionPane.showInputDialog(null, "Enter your email: ");
	    if (!email.contains("@") || !email.endsWith(".com")) 
	    {
	    	//error will shop up to tell the user that they enter the email wrong
	        JOptionPane.showMessageDialog(null, "Invalid email! Please enter a valid email (must contain '@' and end with '.com').");
	        return; //exit the method if email is invaild
	    }
		
		//holder is asked for phone number
		String phoneNumber= JOptionPane.showInputDialog(null, "Enter your phoneNumber: ");
		if(phoneNumber.length() < 10 || !isNumeric(phoneNumber))
		{
			//error will shop up to tell the user that they enter the phone number wrong
			JOptionPane.showMessageDialog(null, "Invalid phone number! Please enter exactly 10 digits.");
			return; //exit the method if phone number is invaild
		}
		
		//holder is asked for balance
		String moneybalance = JOptionPane.showInputDialog(null, "Enter your Balance: ");
		double balance = Double.parseDouble(moneybalance); //convert moneybalance to double balance
		
		//holder is asked for investmentBalance
		String negativeBalance = JOptionPane.showInputDialog(null, "Enter your negative limit for checking account: ");
		double overDraftLimit = Double.parseDouble(negativeBalance); //convert moneybalance to double balance
		
		//store Mutual fund account into array
		bankAccounts[bankCount] = new CheckingAccount(accountNumber, ownerName, email, phoneNumber, balance, overDraftLimit);
		
		//counts the amount of bank accounts created
		bankCount ++;	
		
		//message to user that checking account is added
		JOptionPane.showMessageDialog(null, "Checking Account ADDED SUCCESSFULLY");
	}
		
	private static void CryptoAccount()
	{
		//checks if array if full
		if(bankCount >= bankAccounts.length)
		{	
			//error pops up for holder say that the array is full 
			JOptionPane.showMessageDialog(null, "Can not add any Bank Accounts. Due to Capactiy being Full");
			return;
		}
		
		//holder is asked for account number
		String accountNumber = JOptionPane.showInputDialog(null, "Create Mutual Fund Account Number");
		//check to make sure the account are digits
		if (!isValidAccountNumber(accountNumber)) 
		{
	        JOptionPane.showMessageDialog(null, "Invalid Account Number! Please enter digits only.");
	        return; // Exit if invalid
	    }		
		//holder is asked for name
		String ownerName = JOptionPane.showInputDialog(null, "Enter your full Name: ");
				
		//holder is asked for eamil
		String email = JOptionPane.showInputDialog(null, "Enter your email: ");
	    email = JOptionPane.showInputDialog(null, "Enter your email: ");
	    
	    if (!email.contains("@") || !email.endsWith(".com")) 
	    {
	    	//error will shop up to tell the user that they enter the email wrong
	        JOptionPane.showMessageDialog(null, "Invalid email! Please enter a valid email (must contain '@' and end with '.com').");
	        return; //exit the method if email is invaild
	    }
				
	    //holder is asked for phone number
	  	String phoneNumber= JOptionPane.showInputDialog(null, "Enter your phoneNumber: ");
	  	if(phoneNumber.length() < 10 || !isNumeric(phoneNumber))
	  	{
	  		//error will shop up to tell the user that they enter the phone number wrong
	  		JOptionPane.showMessageDialog(null, "Invalid phone number! Please enter exactly 10 digits.");
	  		return; //exit the method if phone number is invaild
	  	}
			
		//holder is asked for balance
		String moneybalance = JOptionPane.showInputDialog(null, "Enter your Balance: ");
		double balance = Double.parseDouble(moneybalance); //convert moneybalance to double balance
		
		//holder is asked to enter crypto type
		String cryptoType = JOptionPane.showInputDialog(null, "Enter Crypto Type that you want invest into: ");
				
		//holder is asked for CryptoBalance
		String crypto = JOptionPane.showInputDialog(null, "Enter your amount you want to invest into Crypto: ");
		double cryptoBalance = Double.parseDouble(crypto); //convert moneybalance to double balance
				
		//store Mutual fund account into array
		bankAccounts[bankCount] = new CryptoAccount(accountNumber, ownerName, email, phoneNumber, balance, cryptoBalance, cryptoType);
				
		//counts the amount of bank accounts created
		bankCount ++;
		
		//message to user that crypto account is added
		JOptionPane.showMessageDialog(null, "Crypto Account ADDED SUCCESSFULLY");
			
	}
	private static void despoit() 
	{
		//Askes user for the account number
		String accountNumber = JOptionPane.showInputDialog("Enter the Account Number"); 
		
		//find the matching account number
		BankAccount account = null;
		
		//search for the holders account number
		for(int i = 0; i < bankCount; i++)
		{
			if(bankAccounts[i] != null && bankAccounts[i].getAccountNumber().equals(accountNumber))
			{
				account = bankAccounts[i];
				break;
			}
		}
		
		//if account is not found show error
		if(account == null)
		{
			JOptionPane.showMessageDialog(null, "Account not found. Please try again.");
	        return;
		}
		
		//ask the holder for the deposit amount
		String moneyEntered =  JOptionPane.showInputDialog("Enter the amount to deposit:");
		double depositAmount = Double.parseDouble(moneyEntered);
		
		//call the desposit() method from the class
		account.deposit(depositAmount);
	}
	
	private static void withDraw() 
	{
		//ask the user for the account number
		String accountNumber = JOptionPane.showInputDialog("Enter the Account Number"); 
		
		//find the matching the account number
		BankAccount account = null;
		
		//search for the account number 
		for(int i = 0; i < bankCount; i++)
		{
			//decision if the bank accout is not null or is equal to the account number that is stored in array
			if(bankAccounts[i] != null && bankAccounts[i].getAccountNumber().equals(accountNumber))
			{
				account = bankAccounts[i]; // Store the found account
	            break; // Exit loop since we found the account
			}
		}
		
		//if no match then show error
		if(account == null)
		{
			JOptionPane.showMessageDialog(null, "Account not found. Please try again.");
			return;
		}
		
		//Ask the user for the withdrawal amount
		String moneyOut = JOptionPane.showInputDialog("Enter the amount to withdraw:");
		
		//Convert the input to a double
		double withdrawalAmount = Double.parseDouble(moneyOut);
		
		//call the withdraw method in bankAccount class
		account.withDraw(withdrawalAmount);	}
	
	private static void viewAllBankInfo() 
	{
		if(bankCount == 0) 
		{
		    JOptionPane.showMessageDialog(null, "No Bank accounts enter.");
		    return;
		}
		
		//loop that loops thru the vehicle array 
		for(int i = 0 ; i < bankAccounts.length; i++)
		{
			if(bankAccounts[i] != null) //checks if vehicle[i] are empty
			{
				bankAccounts[i].displayAccountInfo(); //display vehicle details from vehicle class
			}
		}
	}

	private static void exitBankingManagmentSystem() 
	{
		// TODO Auto-generated method stub
		JOptionPane.showMessageDialog(null, "You are Exiting the Banking Managment System.");
		JOptionPane.showInputDialog(null, "Enter Yes to leave or No to stay!");	
	}
	
	// Helper method to check if the phone number contains only numbers
	public static boolean isNumeric(String str) 
	{
	    for (char c : str.toCharArray()) 
	    {
	        if (!Character.isDigit(c))
	        {
	            return false; // If any character is not a digit, return false
	        }
	    }
	    return true;
	}
	// Helper method to check if the input contains only digits
	public static boolean isValidAccountNumber(String accountNumber) {
	    if (accountNumber == null || accountNumber.isEmpty()) {
	        return false; // Null or empty input is invalid
	    }

	    for (char c : accountNumber.toCharArray()) {
	        if (!Character.isDigit(c)) {
	            return false; // If any character is not a digit, return false
	        }
	    }
	    return true;
	}
}

