using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace maslyanchuk_E_Lab_9_Chapter_10
{
    //Eric Maslyanchuk
    //CPT-185-A01
    //Lab 9
    //Chpater 10

    class Employee
    {
        //class fields
        private string _Name;
        private string _IdNumber;
        private string _Department;
        private string _Position;

       
        //class properties
        //name
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string IdNumber
        {
            get { return _IdNumber; }
            set { _IdNumber = value; }
        }

        public string Department
        {
            get { return _Department; }
            set { _Department = value; }
        }

        public string Position
        {
            get { return _Position; }
            set { _Position = value; }
        }

        //construtor that takes arguments for name idnumber department position
        public Employee(string name, string idNumber, string department, string position)
        {
            Name = name;
            IdNumber = idNumber;
            Department = department;
            Position = position;
        }

        //the regular parameterless constuctor
        public Employee()
        {
            Name = "";
            IdNumber = "";
            Department = "";
            Position = "";
        }


        //overload contrustor that takes the name and idNumber
        public Employee(string name, string idNumber)
        {
            Name = name;
            IdNumber = idNumber;
            Department = "";
            Position = "";
        }


    }
}
