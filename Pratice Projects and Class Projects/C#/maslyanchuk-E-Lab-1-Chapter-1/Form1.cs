/*
 * Eric Maslyanchuk
 * CPT - 185 - AO1
 * Lab 1
 */

namespace maslyanchukELab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables
        double examTotal;
        double labTotal;
        double quizTotal;
        double finalGrade;
        string letterGrade;

        //varibles for the exam percentage lab percentage and quiz percentage
        double examPercentage = 45;
        double labPercentage = 35;
        double quizPercentage = 20;

        private void examBtn_Click(object sender, EventArgs e)
        {
            //get the average for exams 
            examTotal = (double.Parse(examTextBox1.Text) +
                double.Parse(examTextBox2.Text) +
                double.Parse(examTextBox3.Text) +
                double.Parse(examTextBox4.Text)) / 4;

            examAverageLbl.Text = "Exam Average: " + examTotal;
        }
        private void labBtn_Click(object sender, EventArgs e)
        {
            //get the average for labs
            labTotal = (double.Parse(labTextBox1.Text) +
                double.Parse(labTextBox2.Text) +
                double.Parse(labTextBox3.Text) +
                double.Parse(labTextBox4.Text)
                + double.Parse(labTextBox5.Text)) / 5;

            labAverageLbl.Text = "Lab Average: " + labTotal;

        }
        private void quizBtn_Click(object sender, EventArgs e)
        {
            //get the average for labs
            quizTotal = (double.Parse(quizTextBox1.Text) +
                double.Parse(quizTextBox2.Text) +
                double.Parse(quizTextBox3.Text) +
                double.Parse(quizTextBox4.Text)
                + double.Parse(quizTextBox5.Text)) / 5;

            quizAverageLbl.Text = "Quiz Average: " + quizTotal;

        }

        private void finalBtn_Click(object sender, EventArgs e)
        {
            //set final equal to zero
            finalGrade = 0;

            //this method uses all the averages and calculate the full average
            finalGrade = ((examTotal * examPercentage) +
                (labTotal * labPercentage)
                + (quizTotal * quizPercentage)) / 100;

            //display the final grade 
            finalReusltLbl.Text = "Final Grade: " + finalGrade;

            //get the letter grade
            if (finalGrade >= 90)
            {
                letterGrade = "A";
            }
            else if (finalGrade >= 80)
            {
                letterGrade = "B";
            }
            else if (finalGrade >= 70)
            {
                letterGrade = "C";
            }
            else if (finalGrade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            //display the letter grade
            letterGradeLbl.Text = "Letter Grade: " + letterGrade;
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            //clears all text boxes
            examTextBox1.Clear();
            examTextBox2.Clear();
            examTextBox3.Clear();
            examTextBox4.Clear();

            labTextBox1.Clear();
            labTextBox2.Clear();
            labTextBox3.Clear();
            labTextBox4.Clear();
            labTextBox5.Clear();

            quizTextBox1.Clear();
            quizTextBox2.Clear();
            quizTextBox3.Clear();
            quizTextBox4.Clear();
            quizTextBox5.Clear();

            //clears the variables 
            examTotal = 0;
            labTotal = 0; 
            quizTotal = 0;

            //clears the labels
            examAverageLbl.Text = "Exam Average: ";
            labAverageLbl.Text = "Lab Average: ";
            quizAverageLbl.Text = "Quiz Average: ";
            finalReusltLbl.Text = "Final Grade: ";
            letterGradeLbl.Text = "Letter Grade: ";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();//closes the form
            MessageBox.Show("Thank you! Have a Good Day! God Bless!");
        }

        
    }
}
