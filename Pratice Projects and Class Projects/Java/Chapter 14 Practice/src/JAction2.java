import javax.swing.*;  // Importing Swing components
import java.awt.*;     // Importing AWT classes like Layouts
import java.awt.event.*
;
import java.util.Objects;public class JAction2 extends JFrame implements ActionListener
{
	JLabel label = new JLabel ("Name"); // Creating a label with text "Name"
	JTextField field = new JTextField(12); // Creating a text field with 12 columns
	JButton button = new JButton("Ok"); // Creating a button labeled "Ok"
	
	public JAction2() // Constructor
	{
		super("Frame with Components"); // Calling the superclass constructor to set the frame title
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); // Closes the application when window is closed
		setLayout(new FlowLayout()); // Sets layout to FlowLayout (left-to-right component arrangement)
		add(label); // Adds the label to the frame
		add(field); // Adds the text field to the frame
		add(button); // Adds the button to the frame
		
		//action listener for the button and feild
		button.addActionListener(this);
		field.addActionListener(this);
	}

	@Override
	public void actionPerformed(ActionEvent e) 
	{
		label.setText("Thank you so much");
		button.setText("Application done");
		
		Object source = e.getSource();
		if(source == button)
		{
			label.setText("You clicked the button");
		}
		else
		{
			label.setText("You hit enter");
		}
	}
	
	public static void main(String[] args)
	{
		JAction2 aFrame  = new JAction2();
		final int WIDTH = 250;
		final int HEIGHT = 150;
		aFrame.setSize(WIDTH, HEIGHT);
		aFrame.setVisible(true);
		
	}
}