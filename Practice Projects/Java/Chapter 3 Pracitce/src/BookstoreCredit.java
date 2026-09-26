import java.util.Scanner;

/*
 * To encourage good grades, Hermosa High School has decided to award each student a bookstore credit that is
10 times the student’s grade point average. In other words, a student with a 3.2 grade point average receives a
$32 credit. Create a class that prompts a student for a name and grade point average and then passes the values
to a method that displays a descriptive message. The message uses the student’s name, echoes the grade point
average, and computes and displays the credit. Save the application as BookstoreCredit.java.
 */
public class BookstoreCredit {

	public static void main(String[] args) 
	{
		Scanner input = new Scanner(System.in);
		
		System.out.print("Welcome to Hermosa High School GPA BookCredit" + " \n");
		
		String name;
		double GPA;
		
		System.out.print("Please enter your name: ");
		name = input.nextLine();
		
		System.out.print("Please enter your GPA: ");
		GPA = input.nextDouble();
		
		GetBookCredit(GPA, name);
		
		input.close();

	}

	private static void GetBookCredit(double GPA, String name) 
	{
		double bookCredit;
		
		bookCredit = GPA * 10;
		
        System.out.println("\n--- Bookstore Credit Summary ---");
        System.out.println("Student's Name: " + name + "\n");
        System.out.println("Student's GPA: " + GPA + "\n");
		System.out.print("Book Store Credit: " + bookCredit + "\n");
		
		
	}

}
