using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record
{
    public class Student
    {
        public string Name { get; set; } 
        public int ID { get; set; }
        public double GPA { get; set; }


        public Student (string name, int ID, double GPA)
        {
            this.Name = name;
            this.ID = ID;
            this.GPA = GPA;
        }

        public override string ToString()
        {
            return $"{Name}\t{ID}\t{GPA:F3}";
        }
    }
}
