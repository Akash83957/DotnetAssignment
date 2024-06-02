using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question10
{
    enum DepartmentType
    {
        Finance,
        HR,
        Design,
        Production
    }
    internal class Employee : Person
    {
        // field
        private static int _count = 100;
        private int _id;
        private double _salary;
        private string _designation;
        private DepartmentType _dept;

        // constructor

        public Employee()
        {
            _count++;
            _id = _count;
        }
        public Employee(string name, bool gender, Date birth, string address, double salary, string designation, DepartmentType dept) : base(name, gender, birth, address)
        {
            _count++;
            _id = _count;
            // set value using setter getter
            Salary = salary;
            Designation = designation;
            Dept = dept;
        }



        // Properties
        public int ID
        {
            get { return _id; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }

        public DepartmentType Dept
        {
            get { return _dept; }
            set { _dept = value; }
        }

        public void Accept()
        {
            base.Accept();

            Console.Write("Enter Salary - ");
            Salary = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Designation - ");
            //Designation = Console.ReadLine();

            Console.WriteLine("** Choose Department **");
            Console.WriteLine("0. Finance");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Design");
            Console.WriteLine("3. Production");
            int deptid = Convert.ToInt32(Console.ReadLine());

            switch (deptid)
            {
                case 0: Dept = DepartmentType.Finance; break;
                case 1: Dept = DepartmentType.HR; break;
                case 2: Dept = DepartmentType.Design; break;
                case 3: Dept = DepartmentType.Production; break;
            }

            Console.WriteLine();
        }

        public void Print()
        {
            //Console.WriteLine("\n-- Employee Information --");
            Console.WriteLine("Empid - " + ID);
            base.Print();
            Console.WriteLine("Salary - " + Salary);
            Console.WriteLine("Designation - " + Designation);
            Console.WriteLine("Dept - " + Dept);
        }

        public override string ToString()
        {
            return "[" + ID + " " + Name + " " + (Gender ? "Male" : "Female") + " " + Birth + " " + Age + " " + Address + " " + Salary + " " + Designation + " " + Dept + "]";
        }

    }
}
