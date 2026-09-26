using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maslyanchuk_E_Test_3
{
    public partial class BookForm : Form
    {
        //holds the library object passed from main form
        private Library library;

        //constructor receives the library object
        public BookForm(Library lib)
        {
            InitializeComponent();
            library = lib;   //assign library
            LoadList();      //load books into listbox
        }

        //add book button
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //variables hold the textbox values
                string title = titleTextBox.Text.Trim();
                string autor = autorTextBox.Text.Trim();
                string isbn = isbnTextBox.Text.Trim();

                //check to make sure all fields are filled
                if (title == "" || autor == "" || isbn == "")
                {
                    MessageBox.Show("All fields required.");
                    return;
                }

                //create a new book object
                Book b = new Book(title, autor, isbn);

                //add to library
                library.AddBook(b);

                //reload list
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //loads the listbox with books
        private void LoadList()
        {
            //clear the listbox
            listBoxBooks.Items.Clear();

            //reload all books
            foreach (Book b in library.Books)
            {
                listBoxBooks.Items.Add(b);
            }
        }

        //remove book button
        private void removeBookBtn_Click(object sender, EventArgs e)
        {
            //make sure something is selected
            if (listBoxBooks.SelectedIndex < 0)
            {
                MessageBox.Show("Select a book first");
                return;
            }

            //selected holds the selected book object
            Book selected = (Book)listBoxBooks.SelectedItem;

            //remove the book
            library.RemoveBook(selected.ISBN);

            //reload the list
            LoadList();
        }

        //edit book button
        private void editBookBtn_Click(object sender, EventArgs e)
        {
            //make sure an item is selected
            if (listBoxBooks.SelectedIndex < 0)
            {
                MessageBox.Show("Select a book first");
                return;
            }

            //get the selected book
            Book selected = (Book)listBoxBooks.SelectedItem;

            //edit the properties
            selected.Title = titleTextBox.Text.Trim();
            selected.Autor = autorTextBox.Text.Trim();
            selected.ISBN = isbnTextBox.Text.Trim();

            //reload the listbox
            LoadList();
        }

        //when user clicks a book load the textboxes
        private void listBoxBooks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedIndex >= 0)
            {
                //get the selected book
                Book b = (Book)listBoxBooks.SelectedItem;

                //fill textboxes with the book values
                titleTextBox.Text = b.Title;
                autorTextBox.Text = b.Autor;
                isbnTextBox.Text = b.ISBN;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }
    }
}
