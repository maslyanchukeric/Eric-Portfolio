import javax.swing.*;

public class PlanMenu2 {
	public static void main(String[] args) {
		String guestChoice;

		try {
			Menu2 menu = new Menu2(); // Use Menu2
			PickMenu2 selection = new PickMenu2(menu); // Use PickMenu2
			guestChoice = selection.getMenuChoice();
		} catch (MenuException e) { // Custom exception catch block
			guestChoice = e.getMessage() + " (guessed from initial)";
		} catch (Exception e) { // Generic exception (e.g., number format)
			guestChoice = "Invalid menu selection";
		}

		JOptionPane.showMessageDialog(null, "Menu choice is: " + guestChoice);
	}
}