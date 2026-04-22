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
    public partial class CheckOut : Form
    {
        private Library library;
        public CheckOut(Library lib)
        {
            InitializeComponent();
            library = lib;
            LoadPatron();
            LoadBooks();
        }

        //check out
        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (booksComboBox.SelectedIndex < 0 || patronComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Select book and patron");
                    return;
                }

                Book book = (Book)booksComboBox.SelectedItem;
                Patron patron = (Patron)patronComboBox.SelectedItem;

                bool ok = library.CheckOutBook(book.ISBN, patron.PatronID);

                if (!ok)
                {
                    MessageBox.Show("Book UnAvaible");
                }
                else
                {
                    MessageBox.Show("Checked Out");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //return 
        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (booksComboBox.SelectedIndex < 0 || patronComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Select book and patron");
                return;
            }

            Book book = (Book)booksComboBox.SelectedItem;
            Patron patron = (Patron)patronComboBox.SelectedItem;

            bool ok = library.ReturnBook(book.ISBN, patron.PatronID);

            if (!ok)
            {
                MessageBox.Show("This patron does not have the book");
            }
            else
            {
                MessageBox.Show("Returned");
            }
        }

        //method to load parton 
        private void LoadPatron()
        {
            patronComboBox.Items.Clear();

            foreach (Patron p in library.Patrons)
            {
                patronComboBox.Items.Add(p);

            }
        }

        //method to load books
        private void LoadBooks()
        {
            booksComboBox.Items.Clear();

            foreach (Book b in library.Books)
            {
                booksComboBox.Items.Add(b);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
