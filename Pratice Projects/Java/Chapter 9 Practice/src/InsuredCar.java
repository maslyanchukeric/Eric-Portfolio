 import javax.swing.*;
 public class InsuredCar extends Vehicles implements Insured
 {
	 private int coverage;
	 
	 public InsuredCar()
	 {
		 super("gas", 4);
		 setCoverage();
	 }
	 
	 public void setPrice()
	 {
		 String entry;
		 final int MAX = 60000;
		 entry = JOptionPane.showInputDialog
				 (null, "Enter car price ");
		 price = Integer.parseInt(entry);
		 if(price > MAX)
			 price = MAX;
	 }
	 
	 public int getCoverage()
	 {
		 return coverage;
	 }
	 public void setCoverage()
	 {
		 coverage = (int)(price * 0.9);
	 }
	 
	 public String toString()
	 {
		 return("The insured car is powered by " +
				 getPowerSource() + "; it has " + getWheels() +
				 " wheels, costs $" + getPrice() +
				 " and is insured for $" + getCoverage());
	 }
 }
