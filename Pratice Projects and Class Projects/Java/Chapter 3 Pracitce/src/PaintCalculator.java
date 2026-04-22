import java.util.Scanner;

public class PaintCalculator {

	public static void main(String[] args) {
		double width;
		double height;
		double length;
		
		
		//create a scanner
		Scanner input = new Scanner(System.in);
		
		//ask user for the wall height, length, width
		System.out.println("Enter the wall Length");
		length = input.nextDouble();
		
		System.out.println("Enter the wall Width");
		width = input.nextDouble();
		
		System.out.println("Enter the wall Height");
		height = input.nextDouble();
		
		//calls the method to find area and returns the area
		double area = calculateWallSize( length, width, height);
		
		//variable for the area
		
		
		//calls the method to calculate and returns the number of gallons paint needed
		//displays the number of gallons
		//returns price to main()
		//displays the price of paint
		double price = paintNeeded(area); //price is a variable and is given a place holder
		System.out.print("Paint Total: " + price) ;
		
	}


	private static double calculateWallSize(double length, double width, double height) {
		double area = 2 * (length * height + width * height);
		
		//displays the area of wall
		System.out.println("Area: " + area + "\n");
		 
		return area;
	}
	
	private static double paintNeeded(double area) {
		double coverage = 350; // 1 gallon covers 350 square feet
		double gallons;
		double price;
		
		//area / 350 gets you the amount of gallons needed
		gallons = area / coverage;
		
		//32$ per gallon * gallon gets you price for paint
		price = gallons * 32; // 32$ per gallon
		
		return price;
		// TODO Auto-generated method stub
		
	}

}
