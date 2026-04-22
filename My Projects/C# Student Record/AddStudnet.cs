using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record
{
    public partial class AddStudnet : Form
    {
        List<Student> students; //Student list of studnets
        StreamWriter outputFile; //stream writer to add to the file 

        public AddStudnet(List<Student> students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //variable for user entry
                string name = nameTextBox.Text.Trim();

                //maker sure the user enters good data
                if (!int.TryParse(idTextBox.Text, out int id) ||
                    !double.TryParse(gpaTextBox.Text, out double gpa))
                {
                    MessageBox.Show("Enter a valid, name, ID and Gpa");
                    return;
                }
                if (name == "") //makes sure user enters a name
                {
                    MessageBox.Show("Enter a name");
                    return;
                }
                if (gpa < 0 || gpa > 4) //makes sure gpa is over 0 and under 4
                {
                    MessageBox.Show("GPA must be between 0.0 and 4.0");
                    return;
                }
                if (students.Any(s => s.ID == id))//filer out to see if there is a duplicate id
                {
                    MessageBox.Show("That ID already exists");
                    return;
                }
                //add to the file 
                //write  to file
                outputFile = File.AppendText("students.txt");
                outputFile.WriteLine(name + " " + id + " " + gpa.ToString("F3"));

                //close file
                outputFile.Close();

                //add to the list
                students.Add(new Student(name, id, gpa));

                listBoxAddedName.Items.Clear();
                foreach (Student student in students) //print the to list
                {
                    listBoxAddedName.Items.Add(student.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
