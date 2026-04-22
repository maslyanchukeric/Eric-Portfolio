import java.util.*;

public class PurchasesArrayList 
{

	public static void main(String[] args) 
	{
		ArrayList<Purchase> purchases = new ArrayList<Purchase>();
		
		Scanner kb = new Scanner(System.in);
		String category;
		double price;
		final String QUIT = "ZZZ";
		
		System.out.println("Enter Category for purchases or " + QUIT + " to quit");
		category = kb.nextLine();
		
		while(!category.equals(QUIT))
		{
			System.out.println("Enter the amount spent:");
			price = kb.nextDouble();
			
			purchases.add(new Purchase(category, price));
			
			System.out.print("Enter the category for the purchase or " + QUIT + " to quit");
			category = kb.nextLine();
		}
		
		System.out.println();
		System.out.println("Before sort");
		display(purchases);
		Collections.sort(purchases);
		System.out.println("After sort");
		display(purchases);
	}

	public static void display(ArrayList<Purchase> p)
	{
		for(int x = 0; x < p.size(); x ++)
		{
			System.out.println("  " + p.get(x).getCategory() + " " + p.get(x).getPrice());
			System.out.println();
		}
	}
}
