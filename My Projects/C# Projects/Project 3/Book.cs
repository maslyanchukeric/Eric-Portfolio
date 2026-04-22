using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace maslyanchuk_E_Test_3
{
    public class Book
    {
        //properties
        public string Title { get; set; }
        public string Autor {  get; set; }
        public string ISBN { get; set; }
        public bool ISAvailable { get; set; }

        //Constructor
        public Book()
        {
            Title = string.Empty;
            Autor = string.Empty;
            ISBN = string.Empty;
            ISAvailable = true;
        }

        //parameterzied constructo
        public Book(string title, string Autor, string ISBN)
        {
            this.Title = title;
            this.Autor = Autor;
            this.ISBN = ISBN;
            ISAvailable = true;
        }

        //method to over ride the tostring
        public override string ToString()
        {
            return Title + " by " + Autor + " (ISBN: " + ISBN + ")";
        }

        
    }
}
