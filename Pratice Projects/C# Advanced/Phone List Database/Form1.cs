using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_List_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonelistDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonelistDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.phonelistDataSet.Person);

        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of person: " + this.personTableAdapter.PersonCount());
        }
    }
}
