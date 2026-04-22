using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record
{
    public partial class StudentFinderForm : Form
    {
        List<Student> students;
        public StudentFinderForm(List<Student> students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void findStudentBtn_Click(object sender, EventArgs e)
        {
            //get the student class list called students and loop thur list and find the name
            try
            {
                string name = nameTextBox.Text; //holds name 
                name = name.Trim().ToLower(); //trims the string and all letter are lowercase
                bool found = false; //found is a bool to find the name

                for (int i = 0; i < students.Count; i++) //loops thru the list
                {
                    if (students[i].Name.Trim().ToLower() == name) // finds the student name
                    {
                        listBox1.Items.Add(students[i]);
                        found = true; //found turns true
                    }
                }

                //not found gives the error
                if(!found)
                {
                    MessageBox.Show("Name not Found");
                }
            }
            catch (Exception ex)
            {
                //catch message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
