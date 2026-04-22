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
    public partial class PatronForm : Form
    {
        //holds the library object from main form
        private Library library;

        //constructor receives the library object
        public PatronForm(Library lib)
        {
            InitializeComponent();
            library = lib;   //assigns the library
            LoadList();      //loads the patrons into the listbox
        }

        //adds a patron
        private void addParton_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                string name = nameTextBox.Text.Trim();
                string iD = iDTextBox.Text.Trim();

                //check to make sure the textboxes are filled
                if (name == "" || iD == "")
                {
                    MessageBox.Show("All fields required.");
                    return;
                }

                //creates a new patron
                Patron p = new Patron(name, iD);

                //adds to list in library
                library.AddPatron(p);

                //reload the list
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //loads the listbox with patrons
        private void LoadList()
        {
            //clears the listbox
            listBoxPatron.Items.Clear();

            //reloads the list
            foreach (Patron p in library.Patrons)
            {
                listBoxPatron.Items.Add(p);
            }
        }

        //removes a patron
        private void removePatronBtn_Click(object sender, EventArgs e)
        {
            //make sure something is selected
            if (listBoxPatron.SelectedIndex < 0)
            {
                MessageBox.Show("Select a patron first");
                return;
            }

            //selected holds the selection
            Patron selected = (Patron)listBoxPatron.SelectedItem;

            //removes patron
            library.RemovePatron(selected.PatronID);

            //reloads the list
            LoadList();
        }

        //edits a selected patron
        private void editPatronBtn_Click(object sender, EventArgs e)
        {
            //make sure something is selected
            if (listBoxPatron.SelectedIndex < 0)
            {
                MessageBox.Show("Select a patron first");
                return;
            }

            //selected holds the patron object
            Patron selected = (Patron)listBoxPatron.SelectedItem;

            //updates the properties
            selected.Name = nameTextBox.Text.Trim();
            selected.PatronID = iDTextBox.Text.Trim();

            //reloads the list
            LoadList();
        }

        //when user clicks a patron load the textboxes
        private void listBoxPatron_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPatron.SelectedIndex >= 0)
            {
                //gets selected patron
                Patron p = (Patron)listBoxPatron.SelectedItem;

                //fills the textboxes
                nameTextBox.Text = p.Name;
                iDTextBox.Text = p.PatronID;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
