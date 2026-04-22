import java.util.Scanner;
public class BubbleShortDemo 
{

	public static void main(String[] args) 
	{
		int [] someNums = new int[5];
		int comparisonsToMake = someNums.length - 1;
		Scanner input = new Scanner(System.in);
		int a, b, temp;
		
		for(a = 0; a < someNums.length; ++a)
		{
			System.out.println("Enter number " + (a + 1) + " >> ");
			someNums[a] = input.nextInt();
		}
		
		display(someNums, 0);
		
		for( a = 0; a < someNums.length - 1; ++a)
		{
			for(b = 0; b < comparisonsToMake; ++ b)
			{
				if(someNums[b] > someNums [b + 1])
				{
					temp = someNums[b];
					someNums[b] = someNums[b + 1];
					someNums[b + 1] = temp;
				}
			}
			
			display(someNums, (a + 1));
			--comparisonsToMake;
		}
	}

	private static void display(int[] someNum, int a)
	{
		System.out.println("Iteration " + a + ": ");
		for(int x = 0; x < someNum.length; x++)
		{
			System.out.println(someNum[x] + " ");
			System.out.println();
		}	
	}
}
