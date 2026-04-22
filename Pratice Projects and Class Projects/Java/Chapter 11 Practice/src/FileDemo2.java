// Main class where we execute both writing and reading student data
public class FileDemo2 {

    public static void main(String[] args) {
        
        // Create an instance of StudentProfileWrite to handle writing student data
        StudentProfileWrite mainWriter = new StudentProfileWrite();
        
        // Create an instance of StudentProfileRead to handle reading and displaying the student data
        StudentProfileRead mainReader = new StudentProfileRead();
    }
}