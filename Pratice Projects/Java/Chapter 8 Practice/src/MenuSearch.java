import java.util.Arrays;
import javax.swing.JOptionPane;

public class MenuSearch {
    public static void main(String[] args) {
        // Declare a menu array (max 10 items)
        String[] menuChoices = new String[10];

        // Declare variables
        String entry = "", menuString = "";
        int x = 0, numEntered;
        int highestSub = menuChoices.length - 1;

        // Fill array with placeholder "zzzzzzz" to prevent errors
        Arrays.fill(menuChoices, "zzzzzzz");

        // Ask user for menu items
        menuChoices[x] = JOptionPane.showInputDialog(null,
                "Enter an item for today's menu, or 'zzz' to quit");

        while (!menuChoices[x].equals("zzz") && x < highestSub) {
            menuString += menuChoices[x] + "\n";
            ++x;
            if (x < highestSub) {
                menuChoices[x] = JOptionPane.showInputDialog(null,
                        "Enter an item for today's menu, or 'zzz' to quit");
            }
        }

        // Save the number of actual menu items entered
        numEntered = x;

        // Display full menu and ask user for a selection
        entry = JOptionPane.showInputDialog(null,
                "Today's menu is:\n" + menuString + "Please make a selection:");

        // Sort only the entered items (not "zzzzzzz" placeholders)
        Arrays.sort(menuChoices, 0, numEntered);

        // Search for the user's selection
        x = Arrays.binarySearch(menuChoices, entry);

        // Display search results
        if (x >= 0 && x < numEntered) {
            JOptionPane.showMessageDialog(null, "Excellent choice!");
        } else {
            JOptionPane.showMessageDialog(null, "Sorry - that item is not on tonight's menu.");
        }
    }
}
