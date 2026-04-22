
public class DivdeEvenly 
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		final int LIMIT = 100;
		int var;
		
		System.out.println(LIMIT + " is evenly divisible by" );
		
		//for loop
		for(var = 1; var <= LIMIT; ++var)
		{
			//if limit is a remainder equal to 0 print out the statement
			if(LIMIT % var == 0) 
			{
				System.out.println(var + " ");
			}	
		}
		
		System.out.println();
	}

}
