using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question09
{
    internal class Person
    {
        // field
        private string _name;
        private bool _gender;
        private Date _birth;
        private string _address;
        private int _age;

        // constructor
        public Person()
        {

        }

        public Person(string name, bool gender, Date birth, string address)
        {
            _name = name;
            _gender = gender;
            _birth = birth;
            _address = address;
            Date today = new Date(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            _age = today - _birth;
        }

        // getter setter

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public Date Birth
        {
            get { return _birth; }
            set { _birth = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int Age
        {
            get { return _age; }
        }

        // Method to accept date
        public void Accept()
        {
            Console.Write("Enter Name - ");
            Name = Console.ReadLine() ?? "";

            Console.Write("Enter Gender - ");
            string gender = Console.ReadLine() ?? "";
            if (gender == "Male" || gender == "male" || gender == "m")
                Gender = true;
            else
                Gender = false;

            Console.Write("Enter Birth Date - ");
            _birth = new Date();
            _birth.AcceptDate();

            // setting Age
            Date today = new Date(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            _age = today - _birth;

            Console.Write("Enter Address - ");
            Address = Console.ReadLine() ?? "";
        }

        public void Print()
        {
            //Console.WriteLine("\n-- Person Information --");
            Console.WriteLine("Name - " + Name);
            Console.WriteLine("Gender - " + (Gender ? "Male" : "Female"));
            Console.WriteLine("Birth - " + Birth);
            Console.WriteLine("Age - " + Age);
            Console.WriteLine("Address - " + Address);
        }

        public override string ToString()
        {
            return "[" + Name + " " + (Gender ? "Male" : "Female") + " " + Birth + " " + Age + " " + Address + "]";
        }

    }// end of person
}
