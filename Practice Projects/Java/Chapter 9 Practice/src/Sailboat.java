import javax.swing.*;
public class Sailboat extends Vehicles {

	private int length;
	
	public Sailboat() 
	{
		super("wind", 0);
		setLength();
	}
	
	public void setLength()
	{
		String entry;
		entry = JOptionPane.showInputDialog(null, "Enter sailboat length in feet");
		length = Integer.parseInt(entry);
	}

	public int getLength() 
	{
		return length;
	}
	
	@Override
	public void setPrice()
	{
		String entry;
		final int Max = 100000;
		entry = JOptionPane.showInputDialog(null, "Enter Sailboat price");
		price = Integer.parseInt(entry);
	}
	
	@Override
	public String toString()
	{
		return("The " + getLength() + " foot sailboat powered by " + getPowerSource() + "; it has " + getWheels() + "wheels and costs $ " + getPrice());
	}
}
