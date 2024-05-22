using System;


namespace Assignment5
{
    public class Student
    {
        // field
        private string _name;
        private bool _gender;
        private int _age;
        private int _std;
        private char _div;
        private double _mark;

        // constructor

        public Student()
        {
            _name = "None";
            _gender = false;
            _age = 0;
            _std = 0;
            _div = 'a';
            _mark = 0;
        }

        public Student(string name, bool gender, int age, int std, char div, double mark)
        {
            _name = name;
            _gender = gender;
            _age = age;
            _std = std;
            _div = div;
            _mark = mark;
        }

        // getter setter method

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public bool Gender
        {
            set { _gender = value; }
            get { return _gender; }
        }

        public int Age
        {
            set { _age = value; }
            get { return _age; }
        }

        public int Std
        {
            set { _std = value; }
            get { return _std; }
        }

        public char Div
        {
            set { _div = value; }
            get { return _div; }
        }

        public double Marks
        {
            set { _mark = value; }
            get { return _mark; }
        }

        // Accept Detail method
        public void AcceptDetail()
        {
            Console.Write("Enter Student Name - ");
            Name = Console.ReadLine() ?? "";

            Console.Write("Enter Student Gender - ");
            string gend = Console.ReadLine() ?? "";
            if (gend == "Male" || gend == "male")
                Gender = true;
            else
                Gender = false;

            Console.Write("Enter Student Age - ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Std - ");
            Std = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Div - ");
            Div = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write("Enter Student Mark - ");
            Marks = Convert.ToDouble(Console.ReadLine());
        }

        // print detail method
        public void PrintDetails()
        {
            //Console.WriteLine("-- Student Information --");
            Console.WriteLine("Name - " + Name);
            //string gender = Convert.ToString(Gender);
            //Console.WriteLine("Gender - "+((gender=="True")?"Male":"Female"));
            Console.WriteLine("Gender - " + (Gender ? "Male" : "Female"));
            Console.WriteLine("Age - " + Age);
            Console.WriteLine("Std - " + Std);
            Console.WriteLine("Div - " + Div);
            Console.WriteLine("Marks - " + Marks);
        }
    }
}
