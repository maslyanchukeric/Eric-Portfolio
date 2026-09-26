using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace maslyanchuk_E_Test_3
{
    public class Library
    {
        //create list for books and patrons
        public List<Book> Books = new List<Book>();
        public List<Patron> Patrons = new List<Patron>();

        //Add Book method
        public bool AddBook(Book b)
        {
            //loops thru book list to check duplicate ISBN
            foreach (Book book in Books)
            {
                if (book.ISBN == b.ISBN)
                {
                    return false; //duplicate ISBN
                }
            }

            //adds the book
            Books.Add(b);
            return true;
        }

        //Remove Book method
        public void RemoveBook(string isbn)
        {
            //loops the book list 
            for (int i = 0; i < Books.Count; i++)
            {
                //checks ISBN
                if (Books[i].ISBN == isbn)
                {
                    //removes the book
                    Books.RemoveAt(i);
                    return;
                }
            }
        }

        //Add Patron method
        public bool AddPatron(Patron p)
        {
            //loops thru patron list to check duplicate ID
            foreach (Patron patron in Patrons)
            {
                if (patron.PatronID == p.PatronID)
                {
                    return false; //duplicate ID
                }
            }

            //adds the patron
            Patrons.Add(p);
            return true;
        }

        //Remove Patron method
        public void RemovePatron(string patronID)
        {
            //loops thru patron list 
            for (int i = 0; i < Patrons.Count; i++)
            {
                //compare IDs
                if (Patrons[i].PatronID == patronID)
                {
                    //removes patron
                    Patrons.RemoveAt(i);
                    return;
                }
            }
        }

        //Check out a book
        public bool CheckOutBook(string isbn, string patronId)
        {
            //variables to hold found book and patron
            Book foundBook = Books.FirstOrDefault(b => b.ISBN == isbn);
            Patron foundPatron = Patrons.FirstOrDefault(p => p.PatronID == patronId);

            //if not found return false
            if (foundBook == null || foundPatron == null)
                return false;

            //book must be available
            if (!foundBook.ISAvailable)
                return false;

            //checkout logic
            foundBook.ISAvailable = false;
            foundPatron.BorrowBooks.Add(foundBook);
            return true;
        }

        //Return book method
        public bool ReturnBook(string isbn, string patronId)
        {
            //find the patron
            Patron patron = Patrons.FirstOrDefault(p => p.PatronID == patronId);

            if (patron == null)
                return false;

            //find book in patron borrowed list
            Book bookToReturn = patron.BorrowBooks.FirstOrDefault(b => b.ISBN == isbn);

            if (bookToReturn == null)
                return false;

            //return logic
            patron.BorrowBooks.Remove(bookToReturn);
            bookToReturn.ISAvailable = true;

            return true;
        }

        //Save books to file
        public void SaveBooks(string file)
        {
            //create writer for books.txt
            StreamWriter sw = new StreamWriter("books.txt");
            
                //write each book to file
                foreach (Book b in Books)
                {
                    sw.WriteLine(b.Title + "|" + b.Autor + "|" + b.ISBN + "|" + b.ISAvailable);
                }
            
        }

        //Load books from file
        public void LoadBooks(string file)
        {
            //clear the list
            Books.Clear();

            //make sure file exists
            if (!File.Exists("books.txt"))
                return;

            //read each line in file
            foreach (string line in File.ReadAllLines("books.txt"))
            {
                //split into parts
                string[] parts = line.Split('|');

                //create book object
                Book b = new Book(parts[0], parts[1], parts[2]);

                //set availability
                b.ISAvailable = bool.Parse(parts[3]);

                //add to list
                Books.Add(b);
            }
        }

        //Save patrons to file
        public void SavePatron(string file)
        {
            //create writer for patrons.txt
            StreamWriter sw = new StreamWriter("patrons.txt");
           
                //loop through patrons
                foreach (Patron patron in Patrons)
                {
                    //reset borrowed string
                    string borrowed = "";

                    //add each borrowed ISBN with comma
                    foreach (Book b in patron.BorrowBooks)
                    {
                        borrowed += b.ISBN + ",";
                    }

                    //remove last comma
                    if (borrowed.EndsWith(","))
                        borrowed = borrowed.TrimEnd(',');

                    //write patron info
                    sw.WriteLine(patron.Name + "|" + patron.PatronID + "|" + borrowed);
                }
            
        }

        //Load patrons from file
        public void LoadPatron(string file)
        {
            //clear patron list
            Patrons.Clear();

            //check file
            if (!File.Exists("patrons.txt"))
                return;

            //read lines
            string[] lines = File.ReadAllLines("patrons.txt");

            foreach (string line in lines)
            {
                //split parts
                string[] parts = line.Split('|');

                //create patron object
                Patron p = new Patron(parts[0], parts[1]);
                Patrons.Add(p);

                //load borrowed books
                if (parts.Length > 2 && parts[2] != "")
                {
                    string[] isbnList = parts[2].Split(',');

                    foreach (string isbn in isbnList)
                    {
                        //look for book in book list
                        Book match = Books.FirstOrDefault(b => b.ISBN == isbn);

                        if (match != null)
                        {
                            match.ISAvailable = false;
                            p.BorrowBooks.Add(match);
                        }
                    }
                }
            }
        }
    }
}

