//creating a dog class
public class Dog2 {
	// Field for the dog
	String name;//name of the dog
	int age;//age of the dog

	//constructor
	public Dog2(String n, int a) {
		name = n;
		age = a;
	}
	
	public void bark() {
		//method that makes the dog bark 
		System.out.println(name + " say woof");
	}

	public void displayInfo() {
		//method that displays the dogs info
		System.out.println("Name: " + name + ", Age:" + age);

	}

	public static void main(String[] agrs) {
		//creating a object for dog class called dog1
		Dog2 dog1 = new Dog2("Buddy", 5);
		
		//dog uses the bark method
		dog1.bark();
		
		//dogs info is displayed
		dog1.displayInfo();
	}
}