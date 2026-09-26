import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class BankFrame extends JFrame implements ActionListener {
    private BankManagmentSystem bankSystem;
    private JButton bankAccountBtn; // Declare at class level
    private JButton savingAccountBtn;
    private JButton checkingAccountBtn;
    private JButton mutualFundAccountBtn;
    private JButton cryptoAccountBtn;
    private JButton displayInfoBtn;

    // Constructor
    public BankFrame(BankManagmentSystem system) {
        this.bankSystem = system; // Store reference

        setTitle("Bank Management Systems");
        setSize(500, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new FlowLayout(FlowLayout.LEFT));

        JLabel welcomeLabel = new JLabel("Welcome to Summit Bank");
        JLabel optionLabel = new JLabel("What would you like to do today?");

        // Initialize the class-level button (DO NOT redeclare it)
        //create bank Account button
        bankAccountBtn = new JButton("Create Bank Account");
        bankAccountBtn.addActionListener(this); // Register the event listener
        
        //create saving account button
        savingAccountBtn = new JButton("Create Savings Account");
        savingAccountBtn.addActionListener(this); // Register the event listener
        
        //create checking account button
        checkingAccountBtn = new JButton("Create Checking Account");
        checkingAccountBtn.addActionListener(this); // Register the event listener
        
        //create mutual fund account button
        mutualFundAccountBtn = new JButton("Create MutualFund Account");
        mutualFundAccountBtn.addActionListener(this); // Register the event listener
        
        //create crypto account button
        cryptoAccountBtn = new JButton("Create Crypto Account"); 
        cryptoAccountBtn.addActionListener(this); // Register the event listener
        
        //display all the bank info button
        displayInfoBtn = new JButton("Show all info");
        displayInfoBtn.addActionListener(this); // Register the event listener
        
        // Add components to the frame
        add(welcomeLabel);
        add(optionLabel);
        add(bankAccountBtn);
        add(savingAccountBtn);
        add(checkingAccountBtn);
        add(mutualFundAccountBtn);
        add(cryptoAccountBtn);
        add(displayInfoBtn);
        setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if(e.getSource() == bankAccountBtn) 
        {
            bankSystem.CreateBankAccount(); // Call method from main system
        }
        else if(e.getSource() == savingAccountBtn)
        {
        	bankSystem.SavingsAccount();
        }
        else if(e.getSource() == checkingAccountBtn)
        {
        	bankSystem.CheckingAccount();
        }
        else if(e.getSource() == mutualFundAccountBtn)
        {
        	bankSystem.MutualFundAccount();
        }
        else if(e.getSource() == cryptoAccountBtn)
        {
        	bankSystem.CheckingAccount();
        }
        else if(e.getSource() == displayInfoBtn)
        {
        	bankSystem.viewAllBankInfo();
        }
        
    }
}