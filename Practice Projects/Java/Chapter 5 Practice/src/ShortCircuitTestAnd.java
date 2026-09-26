
public class ShortCircuitTestAnd 
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		if(falseMethod() && trueMethod())
		{
			 System.out.println("Both are true");
		}
		else
		{
			 System.out.println("Both are not true");
		}
		
		
	}
	
	//methods 
	public static boolean trueMethod()
	{
		System.out.println("Within trueMethod()");
		return true;
	}
	
	//method 
	public static boolean falseMethod()
	{
		System.out.println("Within falseMethod()");
		return false;
	}
}
