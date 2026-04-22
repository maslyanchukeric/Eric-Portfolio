// Main class to test the School and NameAndAddress classes
public class SchoolDemo 
{
    public static void main(String[] args) 
    {
        // Creating an object of School with NameAndAddress inside it
        School mySchool = new School("Audubon Elementary", "3500 Hoyne", 60618, 350);
        mySchool.display();
    }
}