
public class PlanVegetarianMenu {

	public static void main(String[] args) {
		String guestChoice;
        try {
            VegetarianMenu briefMenu = new VegetarianMenu();
            PickMenu selection = new PickMenu(briefMenu);
            guestChoice = selection.getGuestChoice();
        } catch (Exception e) {
            guestChoice = "an invalid vegetarian selection";
        }

        javax.swing.JOptionPane.showMessageDialog(null,
                "Menu choice is " + guestChoice);
    }

}
