
public class CreateJFrameWithComponents 
{

	public static void main(String[] args) 
	{
		JFrameWithComponents aFrame = new JFrameWithComponents(); //creating a frame
		final int WIDTH = 350; //setting the width
		final int HEIGHT = 100; //setting the height 
		aFrame.setSize(WIDTH, HEIGHT); //setting the size of the frame
		aFrame.setVisible(true); //setting the frame to be visible
	}
}
