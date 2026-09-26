
import java.util.Scanner;

public class TwoDimensionalArrayDemo {
    public static void main(String[] args) {
        // Declare a 3x3 array (initialized to 0)
        int[][] count = new int[3][3];

        // Scanner for user input
        Scanner input = new Scanner(System.in);
        int row, column;
        final int QUIT = 99;

        // Prompt user for row input
        System.out.print("Enter a row or " + QUIT + " to quit > ");
        row = input.nextInt();

        // Loop continues until user enters QUIT value
        while (row != QUIT) {
            // Prompt for column input
            System.out.print("Enter a column > ");
            column = input.nextInt();

            // Check if row and column are within valid range
            if (row >= 0 && row < count.length && column >= 0 && column < count[row].length) {
                count[row][column]++; // Increment the selected position

                // Display updated array
                for (int r = 0; r < count.length; ++r) {
                    for (int c = 0; c < count[r].length; ++c) {
                        System.out.print(count[r][c] + " ");
                    }
                    System.out.println();
                }
            } else {
                System.out.println("Invalid position selected");
            }

            // Prompt for next row input
            System.out.print("Enter a row or " + QUIT + " to quit > ");
            row = input.nextInt();
        }
    }
}
