import java.awt.*;
public class CrashCanvas extends Canvas implements Runnable
{	
	//position of the car
	private int carX = 100;
	
	private boolean exploded = false;
	
	//explosion dot position
	private int dot1X, dot1Y;
	private int dot2X, dot2Y;
	private int dot3X, dot3Y;
	private int dot4X, dot4Y;
	private int dot5X, dot5Y;
	
	
	
	//Constructor to start the animation thread
	public CrashCanvas()
	{
		//creat the Thread for the animation
		Thread animationThread = new Thread(this);
		
		//animation thread starts
		animationThread.start();
	}

	//method to draw on the canvas
	public void paint(Graphics g)
	{
		//set background color
		g.setColor(Color.LIGHT_GRAY);
		g.fillRect(0, 0, 800, 400); //draw a rectangle for the bacground
		
		//draw the sun 
		g.setColor(Color.YELLOW);
		g.fillOval(50, 50, 60, 60);
		
		//draw the road
		g.setColor(Color.gray);
		g.fillRect(0, 280, 800, 40); //draw ground at bottom of the screen
		
		// Draw yellow center line on the road
		g.setColor(Color.YELLOW);
		g.fillRect(0, 300, 800, 5); // A thin yellow line across the road

		//draw the wheels for the car 
		g.setColor(Color.BLACK);
		g.fillOval(carX + 10, 275, 20, 20); // front wheel
		g.fillOval(carX + 70, 275, 20, 20); // back wheel
		
		//draw the wall
		g.setColor(Color.RED);
		g.fillRect(700, 240, 30, 50); //draws the wall as a rectangle red
		
		//darw the car and explosion
		if(!exploded)	
		{
			//draw the car
			g.setColor(Color.BLUE);
			g.fillRect(carX, 250, 100, 30); //the car 
		}
		else
		{
			//Draw the explosion
			g.setColor(Color.ORANGE);
			g.fillOval(dot1X, dot1Y, 10, 10);
			g.fillOval(dot2X, dot2Y, 10, 10);
			g.fillOval(dot3X, dot3Y, 10, 10);
			g.fillOval(dot4X, dot4Y, 10, 10);
			g.fillOval(dot5X, dot5Y, 10, 10);
			
			//draw the boom
			g.setColor(Color.RED);
			g.setFont(new Font("Arial", Font.BOLD, 36));
			g.drawString("Boom", carX + 20, 220); //message appears above the eplosion
		}
	}

	//animation logic for the car to move 
	@Override
    public void run() {
        // Move car forward
        while (carX < 600) {
            carX += 5;
            repaint();

            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }

        // Trigger the explosion once
        exploded = true;

        // Set initial explosion dot positions around the car
        dot1X = carX + 50; dot1Y = 260;
        dot2X = carX + 55; dot2Y = 255;
        dot3X = carX + 45; dot3Y = 265;
        dot4X = carX + 60; dot4Y = 250;
        dot5X = carX + 40; dot5Y = 270;

        // Animate the explosion
        for (int i = 0; i < 20; i++) {
            dot1X += 1; dot1Y -= 1;
            dot2X += 1; dot2Y += 1;
            dot3X -= 1; dot3Y += 1;
            dot4X -= 1; dot4Y -= 1;
            dot5Y += 2;

            repaint();

            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}