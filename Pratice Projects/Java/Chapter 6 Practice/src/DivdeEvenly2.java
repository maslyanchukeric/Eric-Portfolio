
public class DivdeEvenly2 
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		final int LIMIT = 100;
		int number;
		int var = 0;
		
		System.out.println(LIMIT + " is evenly divisible by" );
		
		//for loop
		 for(number = 1; number <= LIMIT; ++number)
		 {
			 System.out.print(number + " is evenly divisible by ");
			 for(var = 1; var <= number; ++var)
				 if(number % var == 0) 
				 {
					 System.out.print(var + " ");
					 System.out.println();
				 }
		 }	 
	}

}
