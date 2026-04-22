
public class CountingDownDemo 
{

	public static void main(String[] args) 
	{
		countingDown(10);
		System.out.print("BlastOff");
	}

	private static void countingDown(int count) 
	{
		if(count > 0)
		{
			System.out.print(count);
			countingDown(count - 1);
		}	
	}
}
