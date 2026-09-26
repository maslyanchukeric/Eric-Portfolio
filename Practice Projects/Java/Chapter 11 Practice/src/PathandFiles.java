import java.io.*;
import java.nio.file.*;

public class PathandFiles {

	public static void main(String[] args) 
	{
		//Create a path object point to the students.txt
		Path filePath = Paths.get("students.txt");
		
		//check and create a file 
		if(!Files.exists(filePath))
		{
			//trys to create file 
			try {
					Files.createFile(filePath);
					System.out.print("Files Create" + filePath.toAbsolutePath());
			}
			//if theres an error then error message will pop up 
			catch(IOException e)
			{
				System.out.println("Error creating file");
				e.printStackTrace();
			}
		}
		else
		{ 
			//files message come up 
			System.out.println("File already exists");
		}
		
		//Show the file name and abosulote path
		System.out.println("File name: " + filePath.getFileName());
		System.out.println("Absolute Path " + filePath.toAbsolutePath());
		
		//Check if the file exists
		System.out.println("File exist?: " + Files.exists(filePath));
	}

}
