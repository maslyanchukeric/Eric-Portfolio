//imported the java JOption method
import javax.swing.JOptionPane;

public class TestInfo 
{

	public static void main(String[] args) 
	{
		int creditDays = 10;
		System.out.println("Calling method from another class.");
		
		//class method from another class.
		ParadiseInfo.displayInfo();
		
		//creating and using a message box
		JOptionPane.showMessageDialog
		(null, "Every bill is due in " + creditDays + " days.");

	}

}
