
// Bank2Frame GUI class for Summit Bank Management System
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Bank2Frame extends JFrame implements ActionListener {
	// Reference to the main system
	private BankManagmentSystem bankSystem;

	// Declare all buttons for the GUI
	private JButton bankAccountBtn;
	private JButton savingAccountBtn;
	private JButton checkingAccountBtn;
	private JButton mutualFundAccountBtn;
	private JButton cryptoAccountBtn;
	private JButton depositBtn;
	private JButton withdrawBtn;
	private JButton displayInfoBtn;

	// Constructor to initialize the GUI
	public Bank2Frame(BankManagmentSystem system) {
		this.bankSystem = system; // Receive reference to main system

		setTitle("Bank Management System");
		setSize(500, 400);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setLayout(new GridLayout(12, 1, 5, 5)); // Grid layout with 9 rows and spacing

		// Welcome message
		JLabel welcomeLabel = new JLabel("Welcome to Summit Bank", SwingConstants.CENTER);
		JLabel optionLabel = new JLabel("What would you like to do today?");
		JLabel createLabel = new JLabel("ONLY CREATE 5 ACCOUNT PER PERSON");

		// Initialize buttons with descriptive labels
		bankAccountBtn = new JButton("Create Bank Account");
		savingAccountBtn = new JButton("Create Savings Account");
		checkingAccountBtn = new JButton("Create Checking Account");
		mutualFundAccountBtn = new JButton("Create Mutual Fund Account");
		cryptoAccountBtn = new JButton("Create Crypto Account");
		depositBtn = new JButton("Deposit");
		withdrawBtn = new JButton("Withdraw");
		displayInfoBtn = new JButton("Show All Info");

		// Register action listeners
		bankAccountBtn.addActionListener(this);
		savingAccountBtn.addActionListener(this);
		checkingAccountBtn.addActionListener(this);
		mutualFundAccountBtn.addActionListener(this);
		cryptoAccountBtn.addActionListener(this);
		depositBtn.addActionListener(this);
		withdrawBtn.addActionListener(this);
		displayInfoBtn.addActionListener(this);

		// Add components to the frame in order
		add(welcomeLabel);
		add(optionLabel);
		add(createLabel);
		add(bankAccountBtn);
		add(savingAccountBtn);
		add(checkingAccountBtn);
		add(mutualFundAccountBtn);
		add(cryptoAccountBtn);
		add(depositBtn);
		add(withdrawBtn);
		add(displayInfoBtn);

		// Center window on screen
		setLocationRelativeTo(null);
		setVisible(true);
	}

	// Event handler for button clicks
	@Override
	public void actionPerformed(ActionEvent e) {
		if (e.getSource() == bankAccountBtn) {
			bankSystem.CreateBankAccount();
		} else if (e.getSource() == savingAccountBtn) {
			bankSystem.CreateSavingsAccount();
		} else if (e.getSource() == checkingAccountBtn) {
			bankSystem.CreateCheckingAccount();
		} else if (e.getSource() == mutualFundAccountBtn) {
			bankSystem.CreateMutualFundAccount();
		} else if (e.getSource() == cryptoAccountBtn) {
			bankSystem.CreateCryptoAccount();
		} else if (e.getSource() == depositBtn) {
			bankSystem.CreateDepositFrame();
		} else if (e.getSource() == withdrawBtn) {
			bankSystem.CreateWithdrawalFrame();
		} else if (e.getSource() == displayInfoBtn) {
			bankSystem.viewAllBankInfo();
		}
	}
}