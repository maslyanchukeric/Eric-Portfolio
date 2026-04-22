
import java.util.Scanner;

public class InsertionSortDemo 
{
    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);

        //Ask the user for the array size
        System.out.print("Enter the number of elements: ");
        int size = keyboard.nextInt();

        int[] someNums = new int[size]; // ✅ Dynamic array size
        int a, b, temp;

        //Getting user input
        for (a = 0; a < someNums.length; ++a) {
            System.out.print("Enter number " + (a + 1) + " >> ");
            someNums[a] = keyboard.nextInt();
        }

        //Display the initial array
        display(someNums, 0);

        //Insertion Sort Algorithm
        a = 1;
        while (a < someNums.length) {
            temp = someNums[a];
            b = a - 1;

            // Shift elements to make space for the temp value
            while (b >= 0 && someNums[b] > temp) {
                someNums[b + 1] = someNums[b];
                --b;
            }
            someNums[b + 1] = temp;
            display(someNums, a); // ✅ Show array after each iteration
            ++a;
        }

        // ✅ Display final sorted array
        System.out.println("\nFinal Sorted List:");
        display(someNums, -1);
    }

    //Display method to track sorting progress
    public static void display(int[] someNums, int a) {
        if (a == -1)
            System.out.print("Sorted Array: ");
        else
            System.out.print("Iteration " + a + ": ");

        for (int x = 0; x < someNums.length; ++x) {
            System.out.print(someNums[x] + " ");
        }
        System.out.println();
    }
}

