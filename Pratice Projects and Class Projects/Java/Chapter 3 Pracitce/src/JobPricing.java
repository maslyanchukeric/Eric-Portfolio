import java.util.Scanner;
public class JobPricing {

	public static void main(String[] args) {
		
		String jobName;
		double materialCost;
		double jobHours;
		double travelHours;
		
		//create a scanner 
		Scanner input = new Scanner(System.in);
		
		//ask user to enter name of the job
		System.out.println("Please Enter a Job Name: ");
		jobName = input.nextLine();
		
		//ask user the cost of material
		System.out.println("Enter cost of Material ");
		materialCost = input.nextDouble();
		
		//ask user the number of hours required to work
		System.out.println("Enter hours required for job");
		jobHours = input.nextDouble();
		
		//ask user the time for travel required 
		System.out.println("Enter travel time required: ");
		travelHours = input.nextDouble();
		
		//calls a method to calculate the full job.
		double jobCostTotal = calculateCostTotal(materialCost, jobHours, travelHours);
		
		//display the total cost and the rest of the entries
		System.out.println("Job Name: " + jobName);
		System.out.println("Material Cost: " + materialCost);
		System.out.println("job Hours: " + jobHours);
		System.out.println("Travel Hours: " + travelHours);
		System.out.println("Job Cost: " + jobCostTotal);

	}

	public static double calculateCostTotal(double materialCost, double jobHours, double travelHours) {
		double jobCostTotal;
		
		jobCostTotal = materialCost + (35 * jobHours) + (12 * travelHours);
		
		return jobCostTotal;
		
	}

} 
