using System;
using System.Transactions;


namespace Question11
{
    internal class WageEmp : Employee
    {
        private int _hours;
        private int _rate;

        // constructor
        public WageEmp() 
        {
            Designation = "Wage";
        }

        // getter setter
        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        public int Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        public void Accept()
        {
            base.Accept();
            Console.Write("Enter Working Hours - ");
            Hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Working Rate/hr - ");
            Rate = Convert.ToInt32(Console.ReadLine());

            Salary = Rate * Hours;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Working Hours - " + Hours);
            Console.WriteLine("Working Rate/hrs - " + Rate);
        }

        public override string ToString()
        {
            return "[" + ID + " " + Name + " " + (Gender ? "Male" : "Female") + " " + Birth + " " + Age + " " + Address + " " + Salary + " " + Designation + " " + Dept +"]";
        }
    }
}
