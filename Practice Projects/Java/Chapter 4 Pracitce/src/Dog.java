//creating a dog class
public class Dog {
	// Field for the dog
	String name;//name of the dog
	int age;//age of the dog

	
	public void bark() {
		//method that makes the dog bark 
		System.out.println(name + "say woof");
	}

	public void displayInfo() {
		//method that displays the dogs info
		System.out.println("Name: " + name + ", Age:" + age);

	}

	public static void main(String[] agrs) {
		//creating a object for dog class called dog1
		Dog dog1 = new Dog();
		
		//dog1 gets a make called max
		dog1.name = "Max";
		
		//dog1 age is 2
		dog1.age = 2;
		
		//dog uses the bark method
		dog1.bark();
		
		//dogs info is displayed
		dog1.displayInfo();
	}
}
