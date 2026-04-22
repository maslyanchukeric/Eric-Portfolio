using static System.Reflection.Metadata.BlobBuilder;

namespace Student_Record
{
    public partial class Main : Form
    {
        //list of student 
        List<Student> students = new List<Student>();

        //make stream Reader
        StreamReader inputFile;
        StreamWriter outputFile;

        public Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) //load the studnet name, id, gpa
        {
            try
            {
                students.Clear(); //clears the studnets
                listBoxNames.Items.Clear(); //clears the listBox
                listBoxNames.Items.Add("Student Name \t ID \t GPA");
                listBoxNames.Items.Add("-------------\t-----\t----");

                inputFile = File.OpenText("students.txt");

                //read the file 
                while (!inputFile.EndOfStream)
                {
                    //create string called line to read the file 
                    string line = inputFile.ReadLine();

                    //create string array parts to split the name
                    string[] parts = line.Split(" ");

                    //check if there are 4 parts
                    if (parts.Length == 4)
                    {
                        //break each part down
                        string name = parts[0] + " " + parts[1];
                        int id = int.Parse(parts[2]);
                        double gpa = double.Parse(parts[3]);

                        //create a student object
                        students.Add(new Student(name, id, gpa));
                    }
                }

                //display the students in list box
                foreach (Student student in students)
                {
                    listBoxNames.Items.Add(student.ToString());
                }

                //close the file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //catch message
                MessageBox.Show(ex.Message);
            }
        }
        private void findStudnetBtn_Click(object sender, EventArgs e)
        {
            //creates a new form
            Form studentFinder = new StudentFinderForm(students);
            studentFinder.ShowDialog(); //displays the form
        }

        private void addStudentBtnd_Click(object sender, EventArgs e)
        {
            //creating a new form
            Form addingStudnets = new AddStudnet(students);
            addingStudnets.ShowDialog(); //displays form 
            RefreshListBox(); //refreshs the listbox
        }

        private void eixtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeStudentBtn_Click(object sender, EventArgs e)
        {
            // check if user selected a student
            if (listBoxNames.SelectedIndex < 2 )
            {
                MessageBox.Show("Please select a student to remove.");
                return;
            }

            // find the student index in the list
            int studentIndex = listBoxNames.SelectedIndex - 2;

            // remove the student from the list
            students.RemoveAt(studentIndex);

            // update the file (overwrite it)
            outputFile = File.CreateText("students.txt");

            for (int i = 0; i < students.Count; i++)
            {
                outputFile.WriteLine(students[i].Name + " " + students[i].ID + " " + students[i].GPA.ToString("F3"));
            }

            // close the file
            outputFile.Close();

            RefreshListBox();
        }

        private void RefreshListBox()
        {
            //clear the listbox, add header, and divider
            listBoxNames.Items.Clear();
            listBoxNames.Items.Add("Student Name \t ID \t GPA");
            listBoxNames.Items.Add("-------------\t-----\t----");

            //fills the listbox wiht the names, id, & gpa
            foreach (Student student in students)
            {
                listBoxNames.Items.Add(student.ToString());
            }
        }
    }
}
