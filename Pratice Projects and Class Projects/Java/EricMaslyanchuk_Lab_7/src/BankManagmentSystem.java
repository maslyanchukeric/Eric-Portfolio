import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.*;

public class BankManagmentSystem extends JFrame implements ActionListener {

	private String accountType = "";

	// Frames
	private Frame createBankAccountFrame;
	private Frame createSavingsAccountFrame;
	private Frame createCheckingAccountFrame;
	private Frame createMutualFundAccountFrame;
	private Frame createCryptoAccountFrame;
	private Frame depositFrame;
	private Frame withDrawalFrame;
	private Frame showAllInfo;

	// Bank account fields
	private JTextField accNumField;
	private JTextField nameField;
	private JTextField emailField;
	private JTextField phoneNumberField;
	private JTextField balanceField;
	private JTextField interestRateField;
	private JTextField overDraftField;
	private JTextField investmentField;
	private JTextField riskLevelField;
	private JTextField cryptoTypeField;
	private JTextField cryptoBalanceField;

	// Deposit form fields
	private JTextField depositAccNumField;
	private JTextField depositAmountField;

	// Withdrawal form fields
	private JTextField withdrawalAccNumField;
	private JTextField withDrawalAmountField;

	// Buttons
	private JButton bankSubmitButton;
	private JButton savingsSubmitButton;
	private JButton checkingSubmitButton;
	private JButton mutualFundSumitButton;
	private JButton cryptoSubmitButton;
	private JButton depositButton;
	private JButton withDrawalButton;
	private JButton cancelButton;

	boolean found; // hold the found desposit account number and the withdrawal account number

	// add the Jframe
	BankFrame frame1 = new BankFrame(this);

	// bankAccounts array
	private static BankAccount[] bankAccounts = new BankAccount[5];
	private static int bankCount = 0;

	public static void main(String[] args) {
		BankManagmentSystem bankSystem = new BankManagmentSystem();

	}

	// method for Creating a BankAccount
	public void CreateBankAccount() {
		// create new frame for Create Bank Account
		createBankAccountFrame = new JFrame("Create Bank Account");

		// layout for the frame
		createBankAccountFrame.setSize(400, 500);
		createBankAccountFrame.setLayout(new GridLayout(7, 2, 5, 5));
		createBankAccountFrame.setLocationRelativeTo(null); // Center window

		// labels and text fields for the frame
		JLabel accNumLabel = new JLabel("Enter Account Number:");
		accNumField = new JTextField();

		JLabel nameLabel = new JLabel("Enter Full Name:");
		nameField = new JTextField();

		JLabel emailLabel = new JLabel("Enter Email:");
		emailField = new JTextField();

		JLabel phoneNumberLabel = new JLabel("Enter Phone Number:");
		phoneNumberField = new JTextField();

		JLabel balanceLabel = new JLabel("Enter Balance:");
		balanceField = new JTextField();

		bankSubmitButton = new JButton("Submit");
		cancelButton = new JButton("Cancel");

		// add all the labels and text fields
		createBankAccountFrame.add(accNumLabel);
		createBankAccountFrame.add(accNumField);
		createBankAccountFrame.add(nameLabel);
		createBankAccountFrame.add(nameField);
		createBankAccountFrame.add(emailLabel);
		createBankAccountFrame.add(emailField);
		createBankAccountFrame.add(phoneNumberLabel);
		createBankAccountFrame.add(phoneNumberField);
		createBankAccountFrame.add(balanceLabel);
		createBankAccountFrame.add(balanceField);
		createBankAccountFrame.add(bankSubmitButton);
		createBankAccountFrame.add(cancelButton);

		// action listener for the submit button
		accountType = "Bank Account";
		bankSubmitButton.addActionListener(this);
		cancelButton.addActionListener(this);
		createBankAccountFrame.setVisible(true);
	}

	public void CreateSavingsAccount() {
		// create new frame for Create Bank Account
		createSavingsAccountFrame = new JFrame("Create Saving Account");

		// layout for the frame
		createSavingsAccountFrame.setSize(400, 500);
		createSavingsAccountFrame.setLayout(new GridLayout(8, 2, 8, 5));
		createSavingsAccountFrame.setLocationRelativeTo(null); // Center window

		// labels and text fields for the frame
		JLabel accNumLabel = new JLabel("Enter Account Number:");
		accNumField = new JTextField();

		JLabel nameLabel = new JLabel("Enter Full Name:");
		nameField = new JTextField();

		JLabel emailLabel = new JLabel("Enter Email:");
		emailField = new JTextField();

		JLabel phoneNumberLabel = new JLabel("Enter Phone Number:");
		phoneNumberField = new JTextField();

		JLabel balanceLabel = new JLabel("Enter Balance:");
		balanceField = new JTextField();

		// Get the interest rate from user
		JLabel interestRateLabel = new JLabel("Enter Interest Rate (in %):");
		interestRateField = new JTextField();

		// display the calculated interest rate and the amount earned
		JLabel calculatedInterestRate = new JLabel("Calculated Interest Rate : ");
		JLabel interestEarned = new JLabel("Earned Interest: ");

		savingsSubmitButton = new JButton("Submit");
		cancelButton = new JButton("Cancel");

		// add all the labels and text fields
		createSavingsAccountFrame.add(accNumLabel);
		createSavingsAccountFrame.add(accNumField);
		createSavingsAccountFrame.add(nameLabel);
		createSavingsAccountFrame.add(nameField);
		createSavingsAccountFrame.add(emailLabel);
		createSavingsAccountFrame.add(emailField);
		createSavingsAccountFrame.add(phoneNumberLabel);
		createSavingsAccountFrame.add(phoneNumberField);
		createSavingsAccountFrame.add(balanceLabel);
		createSavingsAccountFrame.add(balanceField);
		createSavingsAccountFrame.add(interestRateLabel);
		createSavingsAccountFrame.add(interestRateField);
		createSavingsAccountFrame.add(savingsSubmitButton);
		createSavingsAccountFrame.add(cancelButton);

		// action listener for the submit button
		accountType = "Savings Account";
		savingsSubmitButton.addActionListener(this);
		cancelButton.addActionListener(this);
		createSavingsAccountFrame.setVisible(true);
	}

	public void CreateCheckingAccount() {
		createCheckingAccountFrame = new JFrame("Create Checking Account");

		// layout for the frame
		createCheckingAccountFrame.setSize(400, 500);
		createCheckingAccountFrame.setLayout(new GridLayout(7, 2, 5, 5));
		createCheckingAccountFrame.setLocationRelativeTo(null); // Center window

		// labels and text fields for the frame
		JLabel accNumLabel = new JLabel("Enter Account Number:");
		accNumField = new JTextField();

		JLabel nameLabel = new JLabel("Enter Full Name:");
		nameField = new JTextField();

		JLabel emailLabel = new JLabel("Enter Email:");
		emailField = new JTextField();

		JLabel phoneNumberLabel = new JLabel("Enter Phone Number:");
		phoneNumberField = new JTextField();

		JLabel balanceLabel = new JLabel("Enter Balance:");
		balanceField = new JTextField();

		JLabel overDraftLabel = new JLabel("Enter OverDraft Limit: "); // extra money on the balance + the balance and -
																		// withdraw
		overDraftField = new JTextField();

		checkingSubmitButton = new JButton("Submit");
		cancelButton = new JButton("Cancel");

		// add all the labels and text fields
		createCheckingAccountFrame.add(accNumLabel);
		createCheckingAccountFrame.add(accNumField);
		createCheckingAccountFrame.add(nameLabel);
		createCheckingAccountFrame.add(nameField);
		createCheckingAccountFrame.add(emailLabel);
		createCheckingAccountFrame.add(emailField);
		createCheckingAccountFrame.add(phoneNumberLabel);
		createCheckingAccountFrame.add(phoneNumberField);
		createCheckingAccountFrame.add(balanceLabel);
		createCheckingAccountFrame.add(balanceField);
		createCheckingAccountFrame.add(overDraftLabel);
		createCheckingAccountFrame.add(overDraftField);
		createCheckingAccountFrame.add(checkingSubmitButton);
		createCheckingAccountFrame.add(cancelButton);

		// action listener for the submit button
		accountType = "Checking Account";
		checkingSubmitButton.addActionListener(this);
		cancelButton.addActionListener(this);
		createCheckingAccountFrame.setVisible(true);
	}

	public void CreateMutualFundAccount() {
		createMutualFundAccountFrame = new JFrame("Create Mutual Fund Account");

		// layout for the frame
		createMutualFundAccountFrame.setSize(800, 500);
		createMutualFundAccountFrame.setLayout(new GridLayout(9, 2, 5, 5));
		createMutualFundAccountFrame.setLocationRelativeTo(null); // Center window

		// labels and text fields for the frame
		JLabel accNumLabel = new JLabel("Enter Account Number:");
		accNumField = new JTextField();

		JLabel nameLabel = new JLabel("Enter Full Name:");
		nameField = new JTextField();

		JLabel emailLabel = new JLabel("Enter Email:");
		emailField = new JTextField();

		JLabel phoneNumberLabel = new JLabel("Enter Phone Number:");
		phoneNumberField = new JTextField();

		JLabel balanceLabel = new JLabel("Enter Balance:");
		balanceField = new JTextField();

		JLabel investmentLabel = new JLabel("Enter Invesment amount: ");
		investmentField = new JTextField();

		JLabel riskLevelLabel = new JLabel("Enter Risk Level (Low, Medium, High): ");
		riskLevelField = new JTextField();

		mutualFundSumitButton = new JButton("Submit");
		cancelButton = new JButton("Cancel");

		// add all the labels and text fields
		createMutualFundAccountFrame.add(accNumLabel);
		createMutualFundAccountFrame.add(accNumField);
		createMutualFundAccountFrame.add(nameLabel);
		createMutualFundAccountFrame.add(nameField);
		createMutualFundAccountFrame.add(emailLabel);
		createMutualFundAccountFrame.add(emailField);
		createMutualFundAccountFrame.add(phoneNumberLabel);
		createMutualFundAccountFrame.add(phoneNumberField);
		createMutualFundAccountFrame.add(balanceLabel);
		createMutualFundAccountFrame.add(balanceField);
		createMutualFundAccountFrame.add(investmentLabel);
		createMutualFundAccountFrame.add(investmentField);
		createMutualFundAccountFrame.add(riskLevelLabel);
		createMutualFundAccountFrame.add(riskLevelField);
		createMutualFundAccountFrame.add(mutualFundSumitButton);
		createMutualFundAccountFrame.add(cancelButton);

		// action listener for the submit button
		accountType = "Mutual Fund Account";
		mutualFundSumitButton.addActionListener(this);
		cancelButton.addActionListener(this);
		createMutualFundAccountFrame.setVisible(true);

	}

	public void CreateCryptoAccount() {
		createCryptoAccountFrame = new JFrame("Create Crypto Account");
		createCryptoAccountFrame.setSize(400, 500);
		createCryptoAccountFrame.setLayout(new GridLayout(9, 2, 5, 5));
		createCryptoAccountFrame.setLocationRelativeTo(null); // Center window

		// labels and text fields for the frame
		JLabel accNumLabel = new JLabel("Enter Account Number:");
		accNumField = new JTextField();

		JLabel nameLabel = new JLabel("Enter Full Name:");
		nameField = new JTextField();

		JLabel emailLabel = new JLabel("Enter Email:");
		emailField = new JTextField();

		JLabel phoneNumberLabel = new JLabel("Enter Phone Number:");
		phoneNumberField = new JTextField();

		JLabel balanceLabel = new JLabel("Enter Balance:");
		balanceField = new JTextField();

		JLabel cryptoTypeLabel = new JLabel("Enter Crypto Type: ");
		cryptoTypeField = new JTextField();

		JLabel cryptoBalanceLabel = new JLabel("Enter the amount you want to invest into Crypto:");
		cryptoBalanceField = new JTextField();

		cryptoSubmitButton = new JButton("Submit");
		cancelButton = new JButton("Cancel");

		// add all the labels and text fields
		createCryptoAccountFrame.add(accNumLabel);
		createCryptoAccountFrame.add(accNumField);
		createCryptoAccountFrame.add(nameLabel);
		createCryptoAccountFrame.add(nameField);
		createCryptoAccountFrame.add(emailLabel);
		createCryptoAccountFrame.add(emailField);
		createCryptoAccountFrame.add(phoneNumberLabel);
		createCryptoAccountFrame.add(phoneNumberField);
		createCryptoAccountFrame.add(balanceLabel);
		createCryptoAccountFrame.add(balanceField);
		createCryptoAccountFrame.add(cryptoTypeLabel);
		createCryptoAccountFrame.add(cryptoTypeField);
		createCryptoAccountFrame.add(cryptoBalanceLabel);
		createCryptoAccountFrame.add(cryptoBalanceField);
		createCryptoAccountFrame.add(cryptoSubmitButton);
		createCryptoAccountFrame.add(cancelButton);

		// action listener for the submit button
		accountType = "Crypto Account";
		cryptoSubmitButton.addActionListener(this);
		cancelButton.addActionListener(this);
		createCryptoAccountFrame.setVisible(true);

	}

	public void CreateDepositFrame() {
		depositFrame = new JFrame("Deposit Amount");
		depositFrame.setSize(300, 200);
		depositFrame.setLayout(new GridLayout(4, 2, 5, 5));
		depositFrame.setLocationRelativeTo(null);

		JLabel accNumLabel = new JLabel("Enter Account Number:");
		depositAccNumField = new JTextField();

		JLabel amountLabel = new JLabel("Enter Deposit Amount:");
		depositAmountField = new JTextField();

		depositButton = new JButton("Deposit");
		cancelButton = new JButton("Cancel");

		depositFrame.add(accNumLabel);
		depositFrame.add(depositAccNumField);
		depositFrame.add(amountLabel);
		depositFrame.add(depositAmountField);
		depositFrame.add(depositButton);
		depositFrame.add(cancelButton);

		depositButton.addActionListener(this);
		cancelButton.addActionListener(this);
		depositFrame.setVisible(true);
	}

	public void CreateWithdrawalFrame() {
		withDrawalFrame = new JFrame("Withdrawal Amount");
		withDrawalFrame.setSize(300, 200);
		withDrawalFrame.setLayout(new GridLayout(4, 2, 5, 5));
		withDrawalFrame.setLocationRelativeTo(null);

		JLabel accNumLabel = new JLabel("Enter Account Number:");
		withdrawalAccNumField = new JTextField();

		JLabel amountLabel = new JLabel("Enter Withdrawal Amount:");
		withDrawalAmountField = new JTextField();

		withDrawalButton = new JButton("Withdrawal");
		cancelButton = new JButton("Cancel");

		withDrawalFrame.add(accNumLabel);
		withDrawalFrame.add(withdrawalAccNumField);
		withDrawalFrame.add(amountLabel);
		withDrawalFrame.add(withDrawalAmountField);
		withDrawalFrame.add(withDrawalButton);
		withDrawalFrame.add(cancelButton);

		withDrawalButton.addActionListener(this);
		cancelButton.addActionListener(this);
		withDrawalFrame.setVisible(true);
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// IF THE BANK SUBMIT BUTTON IS HIT
		if (e.getSource() == bankSubmitButton) {
			// checks if array is full
			if (bankCount >= bankAccounts.length) {
				JOptionPane.showMessageDialog(null, "Can not add any Bank Accounts. Due to Capacity being Full");
				return;
			}

			// Validate Account Number
			String accNum = accNumField.getText().trim();
			if (accNum.isEmpty() || !isValidAccountNumber(accNum)) {
				JOptionPane.showMessageDialog(null, "Invalid Account Number! Please enter digits only.");
				return;
			}

			// Validate Name
			String name = nameField.getText().trim();
			if (name.isEmpty()) {
				JOptionPane.showMessageDialog(null, "Please enter your full name.");
				return;
			}

			// Validate Email
			String email = emailField.getText().trim();
			if (email.isEmpty() || !email.contains("@") || !email.endsWith(".com")) {
				JOptionPane.showMessageDialog(null, "Invalid email! Please enter a valid email.");
				return;
			}

			// Validate Phone
			String phone = phoneNumberField.getText().trim();
			if (phone.isEmpty() || phone.length() < 10 || !isNumeric(phone)) {
				JOptionPane.showMessageDialog(null, "Invalid phone number! Please enter exactly 10 digits.");
				return;
			}
			phone = formatPhoneNumber(phone);

			// Validate Balance
			String balanceStr = balanceField.getText().trim();
			if (balanceStr.isEmpty() || !isNumeric(balanceStr)) {
				JOptionPane.showMessageDialog(null, "Invalid balance! Please enter a number.");
				return;
			}
			double balance = Double.parseDouble(balanceStr);

			// BANK ACCOUNT ACTIONS
			BankAccount bank = new BankAccount(accNum, name, email, phone, balance);
			bankAccounts[bankCount] = bank;
			bank.displayAccountInfo();
			bankCount++;
			JOptionPane.showMessageDialog(null, "Account created successfully!");
		}

		// IF THE SAVING SUBMIT BUTTON IS HIT
		if (e.getSource() == savingsSubmitButton) {// checks if array is full
			if (bankCount >= bankAccounts.length) {
				JOptionPane.showMessageDialog(null, "Can not add any Bank Accounts. Due to Capactiy being Full");
				return;
			}

			// Validate Account Number
			String accNum = accNumField.getText().trim();
			if (accNum.isEmpty() || !isValidAccountNumber(accNum)) {
				JOptionPane.showMessageDialog(null, "Invalid Account Number! Please enter digits only.");
				return;
			}

			// Validate Name
			String name = nameField.getText().trim();
			if (name.isEmpty()) {
				JOptionPane.showMessageDialog(null, "Please enter your full name.");
				return;
			}

			// Validate Email
			String email = emailField.getText().trim();
			if (email.isEmpty() || !email.contains("@") || !email.endsWith(".com")) {
				JOptionPane.showMessageDialog(null, "Invalid email! Please enter a valid email.");
				return;
			}

			// Validate Phone
			String phone = phoneNumberField.getText().trim();
			if (phone.isEmpty() || phone.length() < 10 || !isNumeric(phone)) {
				JOptionPane.showMessageDialog(null, "Invalid phone number! Please enter exactly 10 digits.");
				return;
			}
			phone = formatPhoneNumber(phone);

			// Validate Balance
			String balanceStr = balanceField.getText().trim();
			double balance = Double.parseDouble(balanceStr);
			if (balanceStr.isEmpty() || !isNumeric(balanceStr)) {
				JOptionPane.showMessageDialog(null, "Invalid balance! Please enter a number.");
				return;
			}
			// Validate Interest Rate
			String interestRateStr = interestRateField.getText().trim();
			double interestRate = Double.parseDouble(interestRateStr);

			if (interestRateStr.isEmpty() || !isNumeric(interestRateStr)) {
				JOptionPane.showMessageDialog(null, "Please enter a valid interest rate.");
				return;
			}
			SavingsAccount savings = new SavingsAccount(accNum, name, email, phone, balance, interestRate);
			bankAccounts[bankCount] = savings;
			savings.calculateInterest(interestRate); // calcualtes the interest rate
			savings.displayAccountInfo();
			savings.displayInterestRateAndInterestEarned();// displays the interest rate and earnings
			bankCount++;
			// message says that account was created
			JOptionPane.showMessageDialog(null, "Account created successfully!");

		}

		// IF THE CHECKING SUBMIT BUTTON IS HIT
		if (e.getSource() == checkingSubmitButton) {
			// checks if array is full
			if (bankCount >= bankAccounts.length) {
				JOptionPane.showMessageDialog(null, "Can not add any Bank Accounts. Due to Capactiy being Full");
				return;
			}

			// Validate Account Number
			String accNum = accNumField.getText().trim();
			if (accNum.isEmpty() || !isValidAccountNumber(accNum)) {
				JOptionPane.showMessageDialog(null, "Invalid Account Number! Please enter digits only.");
				return;
			}

			// Validate Name
			String name = nameField.getText().trim();
			if (name.isEmpty()) {
				JOptionPane.showMessageDialog(null, "Please enter your full name.");
				return;
			}

			// Validate Email
			String email = emailField.getText().trim();
			if (email.isEmpty() || !email.contains("@") || !email.endsWith(".com")) {
				JOptionPane.showMessageDialog(null, "Invalid email! Please enter a valid email.");
				return;
			}

			// Validate Phone
			String phone = phoneNumberField.getText().trim();
			if (phone.isEmpty() || phone.length() < 10 || !isNumeric(phone)) {
				JOptionPane.showMessageDialog(null, "Invalid phone number! Please enter exactly 10 digits.");
				return;
			}
			phone = formatPhoneNumber(phone);

			// Validate Balance
			String balanceStr = balanceField.getText().trim();
			double balance = Double.parseDouble(balanceStr);
			if (balanceStr.isEmpty() || !isNumeric(balanceStr)) {
				JOptionPane.showMessageDialog(null, "Invalid balance! Please enter a number.");
				return;
			}
			// Vaildate OverDraftLimit
			String overDraftStr = overDraftField.getText().trim();

			// converting the string to the a double call overdraftlimit
			double overdraftLimit = Double.parseDouble(overDraftStr);

			if (overDraftStr.isEmpty() || !isNumeric(overDraftStr)) {
				JOptionPane.showMessageDialog(null, "Please enter a valid Over Draft Limit.");
				return;
			}

			// creating the checking account
			CheckingAccount checking = new CheckingAccount(accNum, name, email, phone, balance, overdraftLimit);
			bankAccounts[bankCount] = checking;
			checking.displayOverDraftLimit(); // display the overdraft limit
			bankCount++;
			// message says that account was created
			JOptionPane.showMessageDialog(null, "Account created successfully!");

		}

		// IF THE MUTUAL FUND SUBMIT BUTTON IS HIT
		if (e.getSource() == mutualFundSumitButton) {// checks if array is full
			if (bankCount >= bankAccounts.length) {
				JOptionPane.showMessageDialog(null, "Can not add any Bank Accounts. Due to Capactiy being Full");
				return;
			}

			// Validate Account Number
			String accNum = accNumField.getText().trim();
			if (accNum.isEmpty() || !isValidAccountNumber(accNum)) {
				JOptionPane.showMessageDialog(null, "Invalid Account Number! Please enter digits only.");
				return;
			}

			// Validate Name
			String name = nameField.getText().trim();
			if (name.isEmpty()) {
				JOptionPane.showMessageDialog(null, "Please enter your full name.");
				return;
			}

			// Validate Email
			String email = emailField.getText().trim();
			if (email.isEmpty() || !email.contains("@") || !email.endsWith(".com")) {
				JOptionPane.showMessageDialog(null, "Invalid email! Please enter a valid email.");
				return;
			}

			// Validate Phone
			String phone = phoneNumberField.getText().trim();
			if (phone.isEmpty() || phone.length() < 10 || !isNumeric(phone)) {
				JOptionPane.showMessageDialog(null, "Invalid phone number! Please enter exactly 10 digits.");
				return;
			}
			phone = formatPhoneNumber(phone);

			// Validate Balance
			String balanceStr = balanceField.getText().trim();
			double balance = Double.parseDouble(balanceStr);
			if (balanceStr.isEmpty() || !isNumeric(balanceStr)) {
				JOptionPane.showMessageDialog(null, "Invalid balance! Please enter a number.");
				return;
			}

			// Validate investments and risk
			String investmentStr = investmentField.getText().trim();
			String risk = riskLevelField.getText().trim();

			// convert investmentStr to double
			double investment = Double.parseDouble(investmentStr);

			MutualFundAccount mutualFund = new MutualFundAccount(accNum, name, email, phone, balance, investment, risk);
			bankAccounts[bankCount] = mutualFund;

			mutualFund.setRiskLevel(risk); // set the risk level
			mutualFund.setInvestmentBalance(investment); // set the investment
			mutualFund.displayInvestmentBalanceAndRisk(); // display both

			bankCount++;

			// message says that account was created
			JOptionPane.showMessageDialog(null, "Account created successfully!");
		}

		// IF THE CRYPTO SUBMIT BUTTON IS HIT
		if (e.getSource() == cryptoSubmitButton) {// checks if array is full
			if (bankCount >= bankAccounts.length) {
				JOptionPane.showMessageDialog(null, "Can not add any Bank Accounts. Due to Capactiy being Full");
				return;
			}

			// Validate Account Number
			String accNum = accNumField.getText().trim();
			if (accNum.isEmpty() || !isValidAccountNumber(accNum)) {
				JOptionPane.showMessageDialog(null, "Invalid Account Number! Please enter digits only.");
				return;
			}

			// Validate Name
			String name = nameField.getText().trim();
			if (name.isEmpty()) {
				JOptionPane.showMessageDialog(null, "Please enter your full name.");
				return;
			}

			// Validate Email
			String email = emailField.getText().trim();
			if (email.isEmpty() || !email.contains("@") || !email.endsWith(".com")) {
				JOptionPane.showMessageDialog(null, "Invalid email! Please enter a valid email.");
				return;
			}

			// Validate Phone
			String phone = phoneNumberField.getText().trim();
			if (phone.isEmpty() || phone.length() < 10 || !isNumeric(phone)) {
				JOptionPane.showMessageDialog(null, "Invalid phone number! Please enter exactly 10 digits.");
				return;
			}
			phone = formatPhoneNumber(phone);

			// Validate Balance
			String balanceStr = balanceField.getText().trim();
			double balance = Double.parseDouble(balanceStr);
			if (balanceStr.isEmpty() || !isNumeric(balanceStr)) {
				JOptionPane.showMessageDialog(null, "Invalid balance! Please enter a number.");
				return;
			}
			// Validate Crypto type and balance
			String cryptoType = cryptoTypeField.getText().trim();
			String cryptoBalanceStr = cryptoBalanceField.getText().trim();

			// convert string to double
			double cryptoBalance = Double.parseDouble(cryptoBalanceStr);

			CryptoAccount crypto = new CryptoAccount(accNum, name, email, phone, balance, cryptoBalance, cryptoType);
			crypto.setCryptoBalance(cryptoBalance);
			crypto.setCryptoType(cryptoType);
			crypto.displayCrypto();

			bankCount++;

			// message says that account was created
			JOptionPane.showMessageDialog(null, "Account created successfully!");

		}

		// IF THE DEPOSIT BUTTON IS HIT
		if (e.getSource() == depositButton) {
			String depositAccNum = depositAccNumField.getText().trim();
			String depositAmountStr = depositAmountField.getText().trim();

			if (depositAccNum.isEmpty() || depositAmountStr.isEmpty()) {
				JOptionPane.showMessageDialog(null, "Please fill in both fields.");
				return;
			}

			if (!isValidAccountNumber(depositAccNum) || !isNumeric(depositAmountStr)) {
				JOptionPane.showMessageDialog(null, "Invalid input.");
				return;
			}

			double depositAmount = Double.parseDouble(depositAmountStr);
			boolean found = false;

			for (int i = 0; i < bankCount; i++) {
				if (bankAccounts[i] != null && bankAccounts[i].getAccountNumber().equals(depositAccNum)) {
					bankAccounts[i].deposit(depositAmount);
					JOptionPane.showMessageDialog(null,
							"Deposit successful! New Balance: $" + bankAccounts[i].getBalance());
					depositFrame.dispose();
					found = true;
					break;
				}
			}
			if (!found) {
				JOptionPane.showMessageDialog(null, "Account not found!");
			}
		}

		// IF THE WITHDRAWAL BUTTON IS HIT
		if (e.getSource() == withDrawalButton) {
			String withDrawalaccNum = withdrawalAccNumField.getText().trim();
			String withdrawalAmountStr = withDrawalAmountField.getText().trim();

			if (withDrawalaccNum.isEmpty() || withdrawalAmountStr.isEmpty()) {
				JOptionPane.showMessageDialog(null, "Please fill in both fields.");
				return;
			}

			if (!isValidAccountNumber(withDrawalaccNum) || !isNumeric(withdrawalAmountStr)) {
				JOptionPane.showMessageDialog(null, "Invalid input.");
				return;
			}

			double withdrawalAmount = Double.parseDouble(withdrawalAmountStr);
			found = false;

			for (int i = 0; i < bankCount; i++) {
				if (bankAccounts[i] != null && bankAccounts[i].getAccountNumber().equals(withDrawalaccNum)) {
					bankAccounts[i].withDraw(withdrawalAmount);
					JOptionPane.showMessageDialog(null,
							"Withdrawal successful! New Balance: $" + bankAccounts[i].getBalance());
					withDrawalFrame.dispose();
					found = true;
					break;
				}
			}
			if (!found) {
				JOptionPane.showMessageDialog(null, "Account not found!");
			}
		}

		// Close the current form frame after success
		if (accountType.equals("Bank Account") && createBankAccountFrame != null) {
			createBankAccountFrame.dispose();
		} else if (accountType.equals("Savings Account") && createSavingsAccountFrame != null) {
			createSavingsAccountFrame.dispose();
		} else if (accountType.equals("Checking Account") && createCheckingAccountFrame != null) {
			createCheckingAccountFrame.dispose();
		} else if (accountType.equals("Mutual Fund Account") && createMutualFundAccountFrame != null) {
			createMutualFundAccountFrame.dispose();
		} else if (accountType.equals("Crypto Account") && createCryptoAccountFrame != null) {
			createCryptoAccountFrame.dispose();
		}

		// clear fields
		accNumField.setText("");
		nameField.setText("");
		emailField.setText("");
		phoneNumberField.setText("");
		balanceField.setText("");
		if (interestRateField != null) {
			interestRateField.setText("");
		}
		if (overDraftField != null) {
			overDraftField.setText("");
		}
		if (investmentField != null) {
			investmentField.setText("");
		}
		if (riskLevelField != null) {
			riskLevelField.setText("");
		}
		if (cryptoTypeField != null) {
			cryptoTypeField.setText("");
		}
		if (cryptoBalanceField != null) {
			cryptoBalanceField.setText("");
		}
		if (depositAmountField != null) {
			depositAmountField.setText("");
		}
		if (withDrawalAmountField != null) {
			withDrawalAmountField.setText("");
		}

		// actions for cancel
		if (e.getSource() == cancelButton) {
			if (createBankAccountFrame != null) {
				createBankAccountFrame.dispose();
			}
			if (createSavingsAccountFrame != null) {
				createSavingsAccountFrame.dispose();
			}
			if (createCheckingAccountFrame != null) {
				createCheckingAccountFrame.dispose();
			}
			if (createMutualFundAccountFrame != null) {
				createMutualFundAccountFrame.dispose();
			}
			if (createCryptoAccountFrame != null) {
				createCryptoAccountFrame.dispose();
			}
			if (depositFrame != null) {
				depositFrame.dispose();
			}
			if (withDrawalFrame != null) {
				withDrawalFrame.dispose();
			}
		}
	}

	public void viewAllBankInfo() {
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

	// Helper method to check if the phone number contains only numbers
	public static boolean isNumeric(String str) {
		for (char c : str.toCharArray()) {
			if (!Character.isDigit(c)) {
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

	// Helper method to format phone number
	public static String formatPhoneNumber(String phone) {
		if (phone.length() == 10) {
			return "(" + phone.substring(0, 3) + ") " + phone.substring(3, 6) + "-" + phone.substring(6);
		} else {
			return phone; // return unformatted if not 10 digits
		}
	}
}
