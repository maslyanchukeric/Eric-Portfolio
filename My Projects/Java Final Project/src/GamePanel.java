import javax.swing.*; // Import GUI components like JPanel, JButton, JLabel
import java.awt.*; // Import graphics and layout tools
import java.awt.event.*; // Import event handling (key presses, button clicks)
import java.util.ArrayList; // Import ArrayList for storing snake body parts
import java.util.List; // Import List interface
import java.util.Random; // Import Random for generating random food locations
import java.awt.Point; // Import Point class (x, y coordinates)

public class GamePanel extends JPanel implements ActionListener, KeyListener {

    // Snake's head position (starting point)
    private int snakeX = 100;
    private int snakeY = 100;

    // Food's position (will change randomly)
    private int foodX = 300;
    private int foodY = 300;

    private Timer timer; // Controls the game loop (updates snake movement)
    private int dx = 20; // Change in X direction (starts moving right)
    private int dy = 0;  // Change in Y direction

    private JButton startButton; // Start game button
    private JButton exitButton;  // Exit game button
    private int score = 0;       // Score counter
    private JLabel scoreLabel;   // Displays the score and level

    private int level = 1;       // Current level
    private int delay = 200;     // Delay between snake moves (lower = faster)

    private List<Point> snakeBody = new ArrayList<>(); // Stores snake body segments
    private Color snakeColor = Color.YELLOW;          // Snake's color
    private Random rand = new Random();               // For generating random numbers (food placement)
    private Color backgroundColor = Color.BLACK;      // Game background color

    // Constructor for the game panel (sets up the initial state)
    public GamePanel() {
        setBackground(backgroundColor); // Set panel background color
        setFocusable(true);             // Allows the panel to receive key presses
        addKeyListener(this);           // Listen for arrow key inputs
        snakeBody.add(new Point(snakeX, snakeY)); // Add the starting snake head to the body list
    }

    // Link the Start button from outside to this panel
    public void setStartButton(JButton button) {
        this.startButton = button;
        this.startButton.addActionListener(this); // Make the button trigger events in this class
    }

    // Link the Exit button from outside to this panel
    public void setExitButton(JButton button) {
        this.exitButton = button;
        this.exitButton.addActionListener(this); // Make the button trigger events in this class
    }

    // Link the score label (from outside the panel)
    public void setScoreLabel(JLabel label) {
        this.scoreLabel = label;
    }

    // This method handles ALL button clicks and game updates (game loop)
    @Override
    public void actionPerformed(ActionEvent e) {
        Object source = e.getSource();

        // If Start button is clicked, start the game
        if (source == startButton) {
            System.out.println("Start button clicked!");
            startButton.setEnabled(false); // Disable the start button once the game starts
            timer = new Timer(delay, this); // Set up the timer to call this method repeatedly
            timer.start();                 // Start the game loop
            requestFocusInWindow();        // Make sure the panel is ready to receive key presses
            return;
        } 
        // If Exit button is clicked, close the game
        else if (source == exitButton) {
            System.out.println("Exit button clicked!");
            System.exit(0);
        } 
        // If the timer is triggering this event (snake movement)
        else if (source == timer) {
            // Move the snake head in the current direction
            snakeX += dx;
            snakeY += dy;

            // Check if the snake hit the wall (Game Over condition)
            if (snakeX < 0 || snakeX >= getWidth() || snakeY < 0 || snakeY >= getHeight()) {
                if (timer != null) {
                    timer.stop(); // Stop the game loop
                    JOptionPane.showMessageDialog(this, "Game Over! The snake hit the wall.\nYour Score: " + score);
                }

                // Ask player if they want to play again
                int option = JOptionPane.showConfirmDialog(this, "Game Over! Do you want to play again?", "Play Again?", JOptionPane.YES_NO_OPTION);
                if (option == JOptionPane.YES_OPTION) {
                    // Reset game state if they want to play again
                    snakeX = 100;
                    snakeY = 100;
                    dx = 20;
                    dy = 0;
                    score = 0;
                    level = 1;
                    delay = 200;
                    backgroundColor = randomColor(); // Random new background color
                    snakeColor = randomColor();      // Random new snake color
                    setBackground(backgroundColor);  // Apply the background color

                    snakeBody.clear(); // Clear old snake body
                    snakeBody.add(new Point(snakeX, snakeY)); // Add initial head position

                    if (scoreLabel != null) {
                        scoreLabel.setText("Score: 0"); // Reset score display
                    }

                    // Generate a new random food position
                    int cellSize = 20;
                    int maxCols = getWidth() / cellSize - 1;
                    int maxRows = getHeight() / cellSize - 1;
                    foodX = rand.nextInt(maxCols + 1) * cellSize;
                    foodY = rand.nextInt(maxRows + 1) * cellSize;

                    timer = new Timer(delay, this); // Restart timer
                    timer.start();
                    requestFocusInWindow();
                } else {
                    System.exit(0); // Exit if they don’t want to play again
                }
                return;
            }

            // Add new head position to the snake body list (grow the snake)
            snakeBody.add(0, new Point(snakeX, snakeY));

            // Check if the snake has eaten the food
            if (snakeX == foodX && snakeY == foodY) {
                score++; // Increase the score

                // Update score label if available
                if (scoreLabel != null) {
                    scoreLabel.setText("Score: " + score + "   Level: " + level);
                }

                // Level up every 5 points, speed up the game
                if (score % 5 == 0) {
                    level++;
                    if (delay > 50) { // Prevent the game from getting too fast
                        delay -= 20;  // Make snake faster
                        timer.setDelay(delay); // Apply new speed
                    }
                }

                // Generate a new food position
                int cellSize = 20;
                int maxCols = getWidth() / cellSize - 1;
                int maxRows = getHeight() / cellSize - 1;
                foodX = rand.nextInt(maxCols + 1) * cellSize;
                foodY = rand.nextInt(maxRows + 1) * cellSize;
            } else {
                // If no food eaten, remove the last part of the snake (so it doesn't grow)
                if (!snakeBody.isEmpty()) {
                    snakeBody.remove(snakeBody.size() - 1);
                }
            }
            repaint();             // Redraw the game
            requestFocusInWindow(); // Keep the panel focused for key inputs
        }
    }

    // Draw the snake, food, and score on the screen
    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        if (timer == null || !timer.isRunning()) {
            // Display welcome message before the game starts
            g.setColor(Color.GREEN);
            g.setFont(new Font("Arial", Font.BOLD, 24));
            g.drawString("Welcome to Snake Game", 160, 300);
        } else {
            // Draw each part of the snake
            for (Point p : snakeBody) {
                g.setColor(snakeColor);
                g.fillRect(p.x, p.y, 20, 20); // Draw each body segment
            }
            // Draw the food
            g.setColor(Color.RED);
            g.fillRect(foodX, foodY, 20, 20);

            // Draw the score and level at the top-left
            g.setColor(Color.WHITE);
            g.setFont(new Font("Arial", Font.BOLD, 16));
            g.drawString("Score: " + score + "   Level: " + level, 10, 20);
        }
    }

    // This method returns a random color (used for background and snake color)
    private Color randomColor() {
        return new Color(rand.nextInt(256), rand.nextInt(256), rand.nextInt(256));
    }

    // Handle arrow key presses to control the snake's direction
    @Override
    public void keyPressed(KeyEvent e) {
        int key = e.getKeyCode();
        // Prevent snake from reversing directly into itself
        if (key == KeyEvent.VK_LEFT && dx == 0) {
            dx = -20;
            dy = 0;
        } else if (key == KeyEvent.VK_RIGHT && dx == 0) {
            dx = 20;
            dy = 0;
        } else if (key == KeyEvent.VK_UP && dy == 0) {
            dx = 0;
            dy = -20;
        } else if (key == KeyEvent.VK_DOWN && dy == 0) {
            dx = 0;
            dy = 20;
        }
    }

    // These two methods are required for KeyListener, but not used in this game
    @Override
    public void keyReleased(KeyEvent e) {}
    @Override
    public void keyTyped(KeyEvent e) {}
}
