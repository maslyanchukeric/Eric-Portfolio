using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maslyanchuk_E_Test_3
{
    public class Patron
    {
        //properties
        public string Name { get; set; }
        public string PatronID { get; set; }
        public List<Book> BorrowBooks { get; set; }

        //constructor 
        public Patron()
        {
            Name = string.Empty;
            PatronID = string.Empty;
            BorrowBooks = new List<Book>();
        }

        //parameterized constructor
        public Patron(string name , string patronId)
        {
            this.Name = name;
            this.PatronID = patronId;
            BorrowBooks = new List<Book>();
        }

        public override string ToString()
        {
            return Name + "(ID: " + PatronID + ")"; 
        }

    }
}
