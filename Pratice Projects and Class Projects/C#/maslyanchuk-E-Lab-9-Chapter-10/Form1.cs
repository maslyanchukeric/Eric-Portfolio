using System.Runtime.CompilerServices;
using System.Text;

namespace maslyanchuk_E_Lab_9_Chapter_10
{
    //Eric Maslyanchuk
    //CPT-185-A01
    //Lab 9
    //Chpater 10
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //get the employees
                Employee employee1 = new Employee("Susan Meyers", "47899", "Accounting", "Vice President");
                Employee employee2 = new Employee("Mark Jones", "39119", "IT", "Programmer");
                Employee employee3 = new Employee("Joy Rogers", "81774", "Manufacturing", "Engineer");
                Employee employee4 = new Employee("James May", "87445");
                Employee employee5 = new Employee();


                //display the name in list box
                nameListBox.Items.Add(employee1.Name);
                nameListBox.Items.Add(employee2.Name);
                nameListBox.Items.Add(employee3.Name);
                nameListBox.Items.Add(employee4.Name);
                nameListBox.Items.Add(employee5.Name);

                //display the id number in list box
                idListBox.Items.Add(employee1.IdNumber);
                idListBox.Items.Add(employee2.IdNumber);
                idListBox.Items.Add(employee3.IdNumber);
                idListBox.Items.Add(employee4.IdNumber);
                idListBox.Items.Add(employee5.IdNumber);

                //displat the department in list box
                departmentListBox.Items.Add(employee1.Department);
                departmentListBox.Items.Add(employee2.Department);
                departmentListBox.Items.Add(employee3.Department);
                departmentListBox.Items.Add(employee4.Department);
                departmentListBox.Items.Add(employee5.Department);

                //display the positions in list box
                positionListBox.Items.Add(employee1.Position);
                positionListBox.Items.Add(employee2.Position);
                positionListBox.Items.Add(employee3.Position);
                positionListBox.Items.Add(employee4.Position);
                positionListBox.Items.Add(employee5.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //clears all the listboxes 
            nameListBox.Items.Clear();
            idListBox.Items.Clear();
            departmentListBox.Items.Clear();
            positionListBox.Items.Clear();

            //focus on the get button
            getBtn.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
