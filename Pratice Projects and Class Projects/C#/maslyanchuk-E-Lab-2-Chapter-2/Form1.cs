/*
 * Eric Maslyanchuk
 * CPT - 185 - AO1
 * Lab 2
 */

namespace maslyanchuk_E_Lab_2
{
    public partial class Cardidentifier : Form
    {
        public Cardidentifier()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //when clicked pic box the answer will show up in the label 
            cardAnswerLbl.Text = "4 Diamonds";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //when clicked pic box the answer will show up in the label 
            cardAnswerLbl.Text = "9 Diamonds";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //when clicked pic box the answer will show up in the label 
            cardAnswerLbl.Text = "Queen Of Diamonds";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //when clicked pic box the answer will show up in the label 
            cardAnswerLbl.Text = "King Of Diamonds";

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //when clicked pic box the answer will show up in the label 
            cardAnswerLbl.Text = "8 Spades";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //closes the form when hitting the exit button
            this.Close();
        }

    }
}
