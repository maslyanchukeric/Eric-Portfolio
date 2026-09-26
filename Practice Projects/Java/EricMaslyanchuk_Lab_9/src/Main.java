import javax.swing.*;
public class Main {

	public static void main(String[] args) 
	{
		//creating the frame 
		JFrame frame1 = new JFrame("Car Crash Animation");
		
		//setting the size of the frame
		frame1.setSize(500, 400);
		
		//close the frame with hitting the close button
		frame1.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		//resizing is fales
		frame1.setResizable(true);
		
		//add a canvas for drawing
		CrashCanvas canvas = new CrashCanvas();
		
		frame1.add(canvas);
		
		//show the frame 
		frame1.setVisible(true);
		

	}

}
