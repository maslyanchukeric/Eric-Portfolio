import javax.swing.JOptionPane;
import java.time.*;

public class TimedResponse //program starts
{

	public static void main(String[] args) //main program
	{
		// TODO Auto-generated method stub
		
		//creating 2 LocalDateTime objects
		LocalDateTime time1, time2;
		
		//hold values of the seconds for both times, & difference between them
		int seconds1, seconds2, difference;
		
		//assigning current time to time1 and extracting the value of current seconds field
		time1 = LocalDateTime.now();
		seconds1 = time1.getSecond();
		
		//display in JOptionPane
		JOptionPane.showConfirmDialog(null, "Is stealing ever justified");
		
		//assigning current time to time2 and extracting the value of current seconds field
		time2 = LocalDateTime.now();
		seconds2 = time2.getSecond();
		
		//calculate the difference between the times and display them 
		difference = seconds2 - seconds1;
		
		JOptionPane.showConfirmDialog(null, "End Seconds: " + seconds2 + "\nStart seconds: " + seconds1 + "\nIt took " + difference + " seconds for you to answer");
		
	}

}
