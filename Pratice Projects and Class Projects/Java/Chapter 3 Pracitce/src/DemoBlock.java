public class DemoBlock {

    public static void main(String[] args) {
        System.out.println("Demonstrating block scope");

        // First block
        int x = 1111;
        System.out.println("In the first block x is " + x);

        // Second block
        {
            int y = 2222; // Declare a new variable y
            System.out.println("In the second block x is " + x);
            System.out.println("In the second block y is " + y);
        }

        // Third block
        {
            int y = 3333; // Declare a new variable y
            System.out.println("In the third block x is " + x);
            System.out.println("In the third block y is " + y);

            // Call demoMethod
            demoMethod();

            System.out.println("After demoMethod x is still " + x);
            System.out.println("After demoMethod y is still " + y);
        }

        // End of main method
        System.out.println("At the end of main x is " + x);
    }

    public static void demoMethod() {
        int x = 8888, y = 9999;
        System.out.println("In demoMethod x is " + x);
        System.out.println("In demoMethod y is " + y);
    }
}
