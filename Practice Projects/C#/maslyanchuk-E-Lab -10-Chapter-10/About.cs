using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maslyanchuk_E_Lab__10_Chapter_10
{
    //Eric Maslyanchuk
    //CPT-185-A01
    //Lab 10

    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Dispose();
        }
    }
}
