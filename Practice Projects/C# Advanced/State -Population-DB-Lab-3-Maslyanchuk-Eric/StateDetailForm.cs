using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Maslyanchuk_Eric
{
    //this form shows the details of the selected state

    public partial class StateDetailForm : Form
    {
        private State _state;

        public StateDetailForm(State selectedState)
        {
            InitializeComponent();
            _state = selectedState;
        }

        //load the state details when the form loads
        private void StateInfoForm_Load(object sender, EventArgs e)
        {
            //showing the state details in labels by ToString method
            stateDetailLbl.Text = _state.ToString();
        }

        //exit button click event handler
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
