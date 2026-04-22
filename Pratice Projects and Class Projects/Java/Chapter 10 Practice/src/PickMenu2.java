import javax.swing.*;

public class PickMenu2 {
    private String guestChoice;

    // Constructor throws MenuException (due to method chain)
    public PickMenu2(Menu2 menu) throws MenuException {
        setGuestChoice(menu);
    }

    // Method explicitly throws MenuException
    public void setGuestChoice(Menu2 menu) throws MenuException {
        guestChoice = menu.displayMenu();
    }

    public String getMenuChoice() {
        return guestChoice;
    }
}
