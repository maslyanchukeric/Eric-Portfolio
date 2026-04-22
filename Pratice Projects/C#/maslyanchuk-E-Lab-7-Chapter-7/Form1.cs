using System;
using System.Drawing.Text;
using System.Reflection;

namespace maslyanchuk_E_Lab_7_Chapter_7
{
    //Eric Maslyanchuk
    //Chapter 7 
    //Lab 7
    //CPT-185-A01

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Create the correct answers array
                string[] correctAnswer = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D",
                                           "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };

                // Create student answers array
                string[] studentAnswer = new string[20];

                // Variable to count correct answers
                int rightAnswers = 0;

                // Open file
                StreamReader inputFile = File.OpenText("Answers.txt");

                int index = 0; //holds the index(element) count

                int grade = 0; //holds the grade of exam

                //reads the file til the end or end of the array
                while (!inputFile.EndOfStream && index < correctAnswer.Length)
                {
                    studentAnswer[index] = inputFile.ReadLine().Trim().ToUpper();

                    //compares the student answers 
                    if (studentAnswer[index] == correctAnswer[index])
                    {
                        //counts up the right answers
                        rightAnswers++;
                    }

                    //holds the count of the elements
                    index++;
                }

                // Close file
                inputFile.Close();

                // Calculate wrong answers
                int wrongAnswers = correctAnswer.Length - rightAnswers;

                // Display student answers into list box
                studentListBox.Items.Clear();
                for (int i = 0; i < studentAnswer.Length; i++)
                {
                    studentListBox.Items.Add("Q" + (i + 1) + ": " + studentAnswer[i]);
                }

                // Display correct answers into list box
                correctListBox.Items.Clear();
                for (int i = 0; i < correctAnswer.Length; i++)
                {
                    correctListBox.Items.Add("Q" + (i + 1) + ": " + correctAnswer[i]);
                }

                // Display totals
                correctAnswerLabel.Text = rightAnswers.ToString();
                incorrectAnswerLabel.Text = wrongAnswers.ToString();



                // Clear old results
                wrongListBox.Items.Clear();

                // Show question numbers that were wrong
                for (int i = 0; i < correctAnswer.Length; i++)
                {
                    if (studentAnswer[i] != correctAnswer[i])
                        wrongListBox.Items.Add("Question " + (i + 1));
                }

                //method that gets grade
                grade = Grade(rightAnswers);

                //display the grade
                gradeLabel.Text = grade.ToString();
                // method that check if student passes or fails
                StudentPassed(rightAnswers);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //bool method checks if student passed and returns status
        private bool StudentPassed(int rightAnswers)
        {
            if (rightAnswers >= 15)
            {
                MessageBox.Show("Student Passed!! Congratulations!");
                return true;
            }
            else
            {
                MessageBox.Show("Student Failed! Please Try Again!");
                return false;
            }
        }

        // method returns a grade
        private int Grade(int rightAnswers)
        {
            int grade; //holds the grade

            grade = (int)((rightAnswers / 20.0) * 100);

            return grade;
        }

        //method to exit the program
        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you, have a good day!");
            this.Close();
        }

        //method to clear the form 
        private void clearBtn_Click(object sender, EventArgs e)
        {
            //clear list box
            studentListBox.Items.Clear();
            correctListBox.Items.Clear();
            wrongListBox.Items.Clear();

            //clear label
            correctAnswerLabel.Text = string.Empty;
            incorrectAnswerLabel.Text = string.Empty;
            gradeLabel.Text = string.Empty;

            //focus on calculate grade

        }
    }
}
