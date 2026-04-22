import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


public class JMyFrame extends JFrame implements ActionListener, ItemListener
{
	final int width = 750;
	final int height = 300;
	
	
	//adding labels
	JLabel fnameLable = new JLabel("First Name: ");
	JLabel lnameLable = new JLabel("Last Name: ");
	JLabel fullNameLabel = new JLabel("Full Name");
	//adding text feilds
	JTextField fname = new JTextField(10);
	JTextField lname = new JTextField(10);
	
	//adding  button 
	JButton submitButton = new JButton("Submit");
	JButton clearButton = new JButton("Clear");
	
	//adding check boxes
	JCheckBox freshman = new JCheckBox("Freshman");
	JCheckBox sophomore = new JCheckBox("Sophmore");
	JCheckBox junior = new JCheckBox("Junior");
	JCheckBox senior = new JCheckBox("Senior");
	
	//adding combo box
	String[] majors = {"English", "Math", "Sociology"};
	JComboBox majorChoice = new JComboBox(majors);
	//constructor
	public JMyFrame()
	{
		super("Our Customized Frame"); // title of the frame
		setSize(width, height); //the width and height of the frame
		setVisible(true); //the frame will pop up on screen
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); //when hitting the x to close the frame the program will stop
		
		//add a flowlayout using layout manager
		setLayout(new FlowLayout(FlowLayout.LEFT));
	
		ButtonGroup classGroup = new ButtonGroup();
		classGroup.add(freshman);
		classGroup.add(sophomore);
		classGroup.add(junior);
		classGroup.add(senior);
		
		//adding to the frame in the order that you want
		add(fnameLable);
		add(fname);
		add(lnameLable);
		add(lname);	
		add(submitButton);
		add(clearButton);
		add(fullNameLabel);
		submitButton.setToolTipText("Submit your name"); //tooltip for the user
		add(freshman);
		add(sophomore);
		add(junior);
		add(senior);
		add(majorChoice);
		
		
		//fname.setEditable(false);//cant edit text in the text field
		//fname.getText(); //get text from fname and gives you the string 
		setVisible(true); //the frame will pop up on screen
		
		submitButton.addActionListener(this); //waits for the button to be clicked refereneing the class (this)
		fname.addActionListener(this);
		lname.addActionListener(this);
		clearButton.addActionListener(this);
		freshman.addItemListener(this);
		sophomore.addItemListener(this);
		junior.addItemListener(this);
		senior.addItemListener(this);
		majorChoice.addActionListener(this);
		
		
	}
	
	//actions take place in method when button is hit
	@Override
	public void actionPerformed(ActionEvent e)
	{
		Object source = e.getSource();
		System.out.println(source);
		fullNameLabel.setText("Full Name: " + fname.getText() + " " + lname.getText());
		System.out.println("User clicked Submit");
		
		if(source == submitButton)
		{
			System.out.println("User hit submit");
			clearButton.setEnabled(true); //user doesn't spam the clear button
			submitButton.setEnabled(false); //user doesn't spam the submit button
		}
		else if(source == fname || source == lname)
		{
			System.out.println("User hit enter");
			clearButton.setEnabled(true); //user doesn't spam the clear button
			submitButton.setEnabled(false); //user doesn't spam the submit button
		}
		else if(source == clearButton)//clears all the user entrys 
		{
			System.out.println("User clicked Clear");
            
            // Clear text fields
            fname.setText("");
            lname.setText("");
            fullNameLabel.setText("Full Name: ");

            // Clear checkboxes (uncheck all)
            freshman.setSelected(false);
            sophomore.setSelected(false);
            junior.setSelected(false);
            senior.setSelected(false);

            // Reset combo box to first option
            majorChoice.setSelectedIndex(0);

            clearButton.setEnabled(false);
            submitButton.setEnabled(true);
		}
		else if (source == majorChoice)
		{
			Object selectedMajor = majorChoice .getSelectedItem();
			System.out.println("User selected Major: " + selectedMajor);
			
		}
	}

	//actions take place in method when checkbox is hit
	@Override
	public void itemStateChanged(ItemEvent e) 
	{
		// TODO Auto-generated method stub
		Object source = e.getItem();
		
		if(source == freshman)
		{
			int select = e.getStateChange();
			if(select == ItemEvent.SELECTED)
			{
				System.out.println("Freshman Selected");
			}
			else
			{
				System.out.println("Freshman DeSelected");
			}
		}
		
		else if(source == sophomore)
		{
			int select = e.getStateChange();
			if(select == ItemEvent.SELECTED)
			{
				System.out.println("sophmore Selected");
			}
			else
			{
				System.out.println("sophmore DeSelected");
			}
		}
		
		else if(source == junior)
		{
			int select = e.getStateChange();
			if(select == ItemEvent.SELECTED)
			{
				System.out.println("junior Selected");
			}
			else
			{
				System.out.println("junior DeSelected");
			}
		}
		
		else if(source == senior)
		{
			int select = e.getStateChange();
			if(select == ItemEvent.SELECTED)
			{
				System.out.println("senior Selected");
			}
			else
			{
				System.out.println("senior DeSelected");
			}
		}
		
		
	}	
}
