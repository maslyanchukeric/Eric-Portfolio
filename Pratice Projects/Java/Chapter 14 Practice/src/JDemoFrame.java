import javax.swing.*; //importing the Jframe class
public class JDemoFrame {

	public static void main(String[] args) 
	{
		JFrame aFrame = new JFrame("This is a frame"); //creates the frame
		final int WIDTH = 300; //sets the width
		final int HEIGHT = 250; //sets the height
		aFrame.setSize(WIDTH, HEIGHT); //sets the size of frame which is 300, 250
		aFrame.setVisible(true); //sets the frame visible
		
		aFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); //closes the frame when the x is clicked
	}

}
