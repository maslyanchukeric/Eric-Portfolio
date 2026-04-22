//creating a dog class
public class Dog4 {
	// Field for the dog
	String name;//name of the dog
	int age;//age of the dog
	
	//count 
	static int count = 0;

	//constructor using the this keyword
	public Dog4(String name, int age) {
		this.name = name;
		this.age = age;
		count ++;
	}
	
	public void bark() {
		//method that makes the dog bark 
		System.out.println(name + " say woof");
	}

	public void displayInfo() {
		//method that displays the dogs info
		System.out.println("Name: " + name + ", Age:" + age);
		//displays the count
		System.out.println("Dog Count: " + Dog4.count);

	}

	public static void main(String[] agrs) {
		//creating a object for dog class called dog1
		Dog4 dog1 = new Dog4("Buddy", 5);
		Dog4 dog2 = new Dog4("Cody" , 4);
		
		//dog uses the bark method
		dog1.bark();
		dog2.bark();
		
		//dogs info is displayed
		dog1.displayInfo();
		dog2.displayInfo();
	}
}