using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Question11
{
    internal class Manager : Employee
    {
        // field
        private double _bonus;

        // constructor
        public Manager()
        {
            Designation = "Manager";
        }

        // property
        public double Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }

        public void Accept()
        {
            base.Accept();
            Console.Write("Enter Bonus - ");
            Bonus = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Bonus - " + Bonus);
        }
        public override string ToString()
        {
            return "[" + ID + " " + Name + " " + (Gender ? "Male" : "Female") + " " + Birth + " " + Age + " " + Address + " " + Salary + " " + Designation + " " + Dept + " " + Bonus + "]";
        }

    }
}
