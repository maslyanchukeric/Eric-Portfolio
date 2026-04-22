import javax.swing.JOptionPane;

//class extends the item class
public class Book extends Item {

	//feild for the book class 
	private String genre;
	private String ISBN;
	
	/*
	 * Parameterized Consturctor
	 * book class inheriting the items class parameters
	 * book title
	 * book author
	 * book year
	 * book genre
	 * book ISBN
	 * 
	 */
	public Book(String title, String autor, int year, String genre, String ISBN) 
	{
		//inherits the item class
		super(title, autor, year);
		
		this.genre = genre;
		this.ISBN = ISBN;
	}
	
	//get the genre and ISBN
	public String getGenre()
	{
		return genre;
	}
	public String getISBN()
	{
		return ISBN;
	}
	
	//set the genre and isbn
	public void setGenre(String genre)
	{
		this.genre = genre;
	}
	public void setISBN(String ISBN)
	{
		this.ISBN = ISBN;
	}
	
	//display the book genre and isbn
	public void displayBook()
	{
		//aslo displays the item info
		displayItem();
		
		JOptionPane.showMessageDialog(null, "\nBook Genre: " + this.genre +
											"\nBook ISBN:  " + this.ISBN);
	}
}
