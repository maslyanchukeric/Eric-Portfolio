public class PreschoolStudent {
    // Variables
    private int IdNum;
    private int age;
            
    // Constant variables
    public static final int HIGH_ID = 9999;
    public static final int HIGH_AGE = 6;
    
    // Constructor
    public PreschoolStudent(int num, int studentAge) {
        setIdNum(num);
        setAge(studentAge); // Fixed incorrect variable name
    }
    
    // Method that ensures ID is no larger than the allowed maximum
    public void setIdNum(int num) {
        if (num <= HIGH_ID) {
            IdNum = num;
        } else {
            IdNum = 0;
        }
    }
    
    // Method that ensures age does not exceed the preschool age limit
    public void setAge(int studentAge) { // Fixed incorrect variable name
        if (studentAge <= HIGH_AGE) {
            age = studentAge;
        } else {
            age = 0;
        }
    } 
    
    // Method to get the ID number
    public int getIdNum() {
        return IdNum;
    }
    
    // Method to get the age
    public int getAge() {
        return age;
    }
    
    // Method to display student information
    public static void display(PreschoolStudent ps) { // Fixed incorrect method signature
        System.out.println("Student ID: " + ps.getIdNum());
        System.out.println("  Student age: " + ps.getAge()); // Fixed syntax error
        System.out.println();
    }

    // Main program
    public static void main(String args[]) {
        PreschoolStudent ps1 = new PreschoolStudent(2345, 5);
        PreschoolStudent ps2 = new PreschoolStudent(67890, 8);
        
        display(ps1); // Corrected method call
        display(ps2); // Corrected method call
        // Removed display(6); as it is incorrect
        ps1.setAge(7);
        display(ps1);
    }
}
