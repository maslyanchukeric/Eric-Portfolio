import javax.swing.*; // Import Swing components
import java.awt.*; // Import AWT for layout and components

public class SnakeGame {
	public static void main(String[] args) {

		// Create the main application window
		JFrame frame = new JFrame("Snake Survival");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); // Close the app when window is closed
		frame.setSize(600, 650); // Set size of the window
		frame.setLayout(new BorderLayout()); // Use BorderLayout

		// Game panel (center of the frame)
		GamePanel gamePanel = new GamePanel();
		frame.add(gamePanel, BorderLayout.CENTER); // Add game panel to the center

		// Create a panel to hold buttons (bottom of the frame)
		JPanel buttonPanel = new JPanel();
		buttonPanel.setLayout(new FlowLayout(FlowLayout.CENTER, 20, 10)); // Centered with spacing

		// Create buttons
		JButton startButton = new JButton("Start Game");
		JButton exitButton = new JButton("Exit Game");
		frame.add(buttonPanel, BorderLayout.SOUTH); // Add button panel to bottom

		// Add buttons to the button panel
		buttonPanel.add(startButton);
		buttonPanel.add(exitButton);

		// Link buttons to the game panel so it can handle clicks
		gamePanel.setStartButton(startButton);
		gamePanel.setExitButton(exitButton);

		frame.setResizable(false); // Lock the window size
		frame.setVisible(true); // Make the frame visible
	}
}
