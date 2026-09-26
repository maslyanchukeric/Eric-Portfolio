import java.time.*;
 public class TestFuseLoopTime
 {
	 public static void main(String[] args)
	 {
		 int startTime, endTime;
		 int x;
		 final int PAT = 5_000_000;
		 final int FACT = 1_000_000;
		 
		 LocalDateTime now;
		 now = LocalDateTime.now();
		 startTime = now.getNano();
		 
		 for(x = 0; x < PAT; ++x)
		 {
			 method1();
		 }
		
		 for(x = 0; x < PAT; ++x)
		 {
			 method2();
		 }
		 
		 now = LocalDateTime.now();
		 endTime = now.getNano();
		 System.out.println("Time for loops executed separately: " +
		 ((endTime - startTime) / FACT) + " milliseconds");
		 
		 now = LocalDateTime.now();
		 startTime = now.getNano();
		 for(x = 0; x < PAT; ++x)
		 {
			 method1();
			 method2();
		 }
		 
		 now = LocalDateTime.now();
		 endTime = now.getNano();
		 System.out.println("Time for loops executed in a block: " +
		 ((endTime - startTime) / FACT) + " milliseconds");
	 }
	
	 public static void method1() 
	 {
		 
	 }
	 
	 public static void method2()
	 {
		 
	 }	 
}