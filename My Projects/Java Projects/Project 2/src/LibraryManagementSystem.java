import javax.swing.JOptionPane;

//main program for the library management system
public class LibraryManagementSystem 
{
	//create array of items
	static Item[] items = new Item[5];
	static int itemCount = 0; //holds the amount of items in list/array
	
	public static void main(String[] args) 
	{	
		//creating new item
		Item item1 = new Item(null, null, 0); //holds null until user enter in info
		
		String userEntry; //hold user entry
		String staying = "No"; // no will exit the loop and program
		
		while(staying.equalsIgnoreCase("No"))
		{
			//itemMenu will ask user to enter an item, book, Dvd, Cd, Laptop
			userEntry = itemMenu();
			int choice = Integer.parseInt(userEntry);
			
			//options that user choice
			switch(choice)
			{
				case 1:
					addItem();
					break;
				case 2:
					addBook();
					break;
				case 3:
					addDvd();
					break;
				case 4: 
					addCd();
					break;
				case 5: 
					addLaptop();
					break;
				case 6: 
					displayAllItems();
					break;
				case 7: 
					searchItem();
					break;
				case 8:
					checkoutITem();
					break;
				case 9:
					JOptionPane.showMessageDialog(null, "Exiting the library Management System");				
			}
			
			staying = JOptionPane.showInputDialog(null, "Enter Yes to leave or No to stay");
		}
	}

	private static boolean checkoutITem() 
	{//ask user to enter item title
		String title = JOptionPane.showInputDialog(null, "Please enter the title of Item, Book, Cd, Dvd, Laptop that you want to check out");
		
		//find the matching title
		Item title1 = null;
		
		//search for the matching title
		for(int i = 0; i < itemCount; i++)
		{
			//if are not empty and the title1 match one of the elements
			if(items[i] != null && items[i].getTitle().equals(title))
			{
				title1 = items[i];
				
				JOptionPane.showMessageDialog(null, title + " item is avaliable. You can checkout the book");
				return true;
			}
			
		}
		
		if(title1 == null)
		{
			JOptionPane.showMessageDialog(null, title + " the item is not avaliable");
			return false;
		}
		
	JOptionPane.showInputDialog(null, title + " the item is not avaliable");
	return false;
	
		
		
	}

	private static void searchItem() 
	{
		//ask user to enter item title
		String title = JOptionPane.showInputDialog(null, "Please enter the title of Item, Book, Cd, Dvd, Laptop");
		
		//find the matching title
		Item title1 = null;
		
		//search for the matching title
		for(int i = 0; i < itemCount; i++)
		{
			//if are not empty and the title1 match one of the elements
			if(items[i] != null && items[i].getTitle().equals(title))
			{
				title1 = items[i];
				JOptionPane.showMessageDialog(null, title + " found!");
			}
			
		}
		
		if(title1 == null)
		{
			JOptionPane.showMessageDialog(null, "Title not found. Please try again");
		}
		
	}

	private static void displayAllItems() 
	{
		if(itemCount == 0)
		{
			JOptionPane.showMessageDialog(null, "No Items in array");
			
		}
		
		//loop thru the items array
		for(int i = 0; i < items.length; i++)
		{
			if(items[i] != null)
			{
				items[i].displayItem();
			}
		}
		
		return;
	}

	private static void addLaptop() 
	{
		//check if item array is full
		if(itemCount >= items.length)
		{
			//error say that array is full
			JOptionPane.showMessageDialog(null, "Library full please try again");
		}
				
		//user is asked to enter the item info
		String title = JOptionPane.showInputDialog(null, "Enter Latop Title");
		
		String autor = JOptionPane.showInputDialog(null, "Enter Laptop Autor");
				
		String made = JOptionPane.showInputDialog(null, "Enter Laptop Year ");
		int year = Integer.parseInt(made); //converts the string to an int
				
		String model = JOptionPane.showInputDialog(null, "Enter Laptop Model");
				
		String type = JOptionPane.showInputDialog(null, "Enter Laptop Type");
		
		
		//store the item into the array
		items[itemCount] = new Laptop(title, autor, year, model, type);
				
		//count goes up when item is stored
		itemCount ++;
				
		//display that item was added
		JOptionPane.showMessageDialog(null, "DVD is added!");

		
		
	}

	private static void addCd() 
	{
		//check if item array is full
		if(itemCount >= items.length)
		{
			//error say that array is full
			JOptionPane.showMessageDialog(null, "Library full please try again");
		}
						
		//user is asked to enter the item info
		String title = JOptionPane.showInputDialog(null, "Enter CD Title");
				
		String autor = JOptionPane.showInputDialog(null, "Enter CD Autor");
						
		String made = JOptionPane.showInputDialog(null, "Enter CD Year ");
		int year = Integer.parseInt(made); //converts the string to an int
						
		String mediaType = JOptionPane.showInputDialog(null, "Enter CD Media Type");
						
		String cdLength = JOptionPane.showInputDialog(null, "Enter CD Duration in mins");
		int cdDuration = Integer.parseInt(cdLength); //converts the string to an int	
				
		//store the item into the array
		items[itemCount] = new CD(title, autor, year, mediaType, cdDuration);
						
		//count goes up when item is stored
		itemCount ++;
						
		//display that item was added
		JOptionPane.showMessageDialog(null, "Cd is added!");
	}

	private static void addDvd() 
	{
		//check if item array is full
		if(itemCount >= items.length)
		{
			//error say that array is full
			JOptionPane.showMessageDialog(null, "Library full please try again");
		}
				
		//user is asked to enter the item info
		String title = JOptionPane.showInputDialog(null, "Enter DVD Title");
		
		String autor = JOptionPane.showInputDialog(null, "Enter DVD Autor");
				
		String made = JOptionPane.showInputDialog(null, "Enter DVD Year ");
		int year = Integer.parseInt(made); //converts the string to an int
				
		String director = JOptionPane.showInputDialog(null, "Enter DVD Name");
				
		String filmLength = JOptionPane.showInputDialog(null, "Enter DVD in mins");
		int duration = Integer.parseInt(filmLength); //converts the string to an int	
		
		//store the item into the array
		items[itemCount] = new DVD(title, autor, year, director, duration);
				
		//count goes up when item is stored
		itemCount ++;
				
		//display that item was added
		JOptionPane.showMessageDialog(null, "DVD is added!");
		
		
	}

	private static void addBook() 
	{
		//check if item array is full
		if(itemCount >= items.length)
		{
			//error say that array is full
			JOptionPane.showMessageDialog(null, "Library full please try again");
		}
				
		//user is asked to enter the item info
		String title = JOptionPane.showInputDialog(null, "Enter Book Title");
		
		String autor = JOptionPane.showInputDialog(null, "Enter Book Autor");
				
		String made = JOptionPane.showInputDialog(null, "Enter Book Year ");
		int year = Integer.parseInt(made); //converts the string to an int
				
		String genre = JOptionPane.showInputDialog(null, "Enter Book Genre");
				
		String ISBN = JOptionPane.showInputDialog(null, "Enter Book ISBN");
				
		//store the item into the array
		items[itemCount] = new Book(title, autor, year, genre, ISBN);
				
		//count goes up when item is stored
		itemCount ++;
				
		//display that item was added
		JOptionPane.showMessageDialog(null, "Book is added!");
		
	}

	private static void addItem() 
	{
		//check if item array is full
		if(itemCount >= items.length)
		{
			//error say that array is full
			JOptionPane.showMessageDialog(null, "Library full please try again");
		}
		
		//user is asked to enter the item info
		String title = JOptionPane.showInputDialog(null, "Enter Item Title");
		
		String autor = JOptionPane.showInputDialog(null, "Enter Item Autor");
		
		String made = JOptionPane.showInputDialog(null, "Enter Item Year ");
		int year = Integer.parseInt(made); //converts the string to an int
		
		//store the item into the array
		items[itemCount] = new Item(title, autor, year);
		
		//count goes up when item is stored
		itemCount ++;
		
		//display that item was added
		JOptionPane.showMessageDialog(null, "Item is added!");
	}
	
		
	

	//menu for user to choice from
	private static String itemMenu()
	{
		
		return JOptionPane.showInputDialog(null, "Weclome to the Library Management System\n" + 
										     "****************************************\n" + 
										     "1. Add Item\n " +
											 "2. Add Book\n" +
										     "3. Add DVD\n" +
											 "4. Add CD\n" +
										     "5. Add Laptop\n" +
											 "6. Display Current list\n" +
										     "7. Search for an Item\n" +
											 "8. Check out item\n" +
										     "9. Exit library system\n" + 
										     "****************************************\n" + 
										     "Choice an option 1-9"
										     );
		
	}
}
