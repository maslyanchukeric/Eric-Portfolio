import javax.swing.JOptionPane;


public class MutualFundAccount extends BankAccount
{
	//feilds that holds investment Balanace and the risk level
	private double investmentBalance;
	private String riskLevel;
	
	//default Constructor
	public MutualFundAccount()
	{//default constructor initializing investmentBalance to 0
		investmentBalance = 0.0;
		
		//default constructor initializing riskLeve to empty
		riskLevel = "";
	}
	
	/*
	 *  Parameterized Constructor
	 *  accountNumber - Unique account ID
	 *  ownerName - Name of the account holder
	 *  email - Email of the account holder
	 *  phoneNumber - Contact number of the account holder
	 *  balance - Initial account balance
	 *  investmentBalance - holder enters an amount the want to invest
	 *  riskLevel - holder choices the risk level they want the investment in
	 */
	//constructor 
	public MutualFundAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance, double investmentBalance, String riskLevel)
	{
		// Calls the constructor of the parent class (BankAccount)
		super(accountNumber, ownerName, email, phoneNumber, balance);
		this.investmentBalance = investmentBalance;
		this.riskLevel = riskLevel;
	}
	
	//getting the investment balance and the risk level
	public double getInvestmentBalance()
	{
		return investmentBalance;
	}
	
	public String getRiskLevel() 
	{
		return riskLevel;
	}
	
	//setting investment balance and risk level
	public void setInvestmentBalance(double investment)
	{
		//check if investment is not negative
		if(investment > 0)
		{
			//investmentBalance is set as investment
			this.investmentBalance = investment;
			
			//shows message for holder 
			JOptionPane.showMessageDialog(null, "New Investment Balance: $" + this.investmentBalance);
		}
		else
		{
			//shows message for holder that they entered a error
			JOptionPane.showMessageDialog(null, "Invalid please a vaild amount");
		}
	}
	
	public  void setRiskLevel(String risk)
	{
		//holder enters a risk level 
		if (risk.equalsIgnoreCase("Low") || risk.equalsIgnoreCase("Medium") || risk.equalsIgnoreCase("High")) 
        {
            this.riskLevel = risk;
        } 
        else 
        {
        	//holder gets an error on the entry 
            JOptionPane.showMessageDialog(null, "Invalid risk level! Must be Low, Medium, or High.");
            this.riskLevel = "Low"; // Default if invalid
        }
	}
	
	//display the bank and the investment and risk
	public void displayInvestmentBalanceAndRisk()
	{
    	
    	//shows holder the investment and risk level
    	JOptionPane.showMessageDialog(null, "Investment: " + getInvestmentBalance() +
    										"\nRisk Level: " + getRiskLevel());
	}
}