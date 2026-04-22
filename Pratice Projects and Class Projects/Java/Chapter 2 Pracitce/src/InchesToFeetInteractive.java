import java.util.Scanner;
public class InchesToFeetInteractive {

	public static void main(String[] args) {
		
		int inches = 0;
		int feet;
		int remainingInches; 
		Scanner input = new Scanner(System.in);
		
		System.out.println("Please Enter inches: ");
		inches = input.nextInt();
		
		feet = inches / 12;
		
		remainingInches  = 12 % feet;
		
		System.out.println("Feet: " + feet + " inches: " + remainingInches );
	}

}
