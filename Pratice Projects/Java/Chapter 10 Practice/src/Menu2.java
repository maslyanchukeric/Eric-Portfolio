import javax.swing.*;

public class Menu2 {
    protected String[] entreeChoices = {
        "Rosemary Chicken", "Beef Wellington", "Vegetable Stir Fry"
    };

    protected char[] initials = new char[entreeChoices.length];

    public String displayMenu() throws MenuException {
        String menuString = "Type the number of your selection:";
        for (int x = 0; x < entreeChoices.length; ++x) {
            menuString += "\n" + x + " - " + entreeChoices[x];
            initials[x] = entreeChoices[x].charAt(0); // Store first letter
        }

        String input = JOptionPane.showInputDialog(null, menuString);

        // Handle if user enters first letter of an entree
        for (int y = 0; y < entreeChoices.length; ++y) {
            if (input.charAt(0) == initials[y]) {
                throw new MenuException(entreeChoices[y]);
            }
        }

        // Otherwise, parse as number
        int selectedIndex = Integer.parseInt(input);

        if (selectedIndex < 0 || selectedIndex >= entreeChoices.length)
            throw new NumberFormatException("Invalid numeric selection");

        return entreeChoices[selectedIndex];
    }
}

