using System;


namespace Question11
{
    internal class Supervisor : Employee
    {
        private int _subordinate;

        public Supervisor()
        {
            Designation = "Supervisor";
        }

        public int Subordinate
        {
            get { return _subordinate; }
            set { _subordinate = value; }
        }

        public void Accept()
        {
            base.Accept();

            Console.Write("Enter No. of Assistants - ");
            Subordinate = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Subordinate - " + Subordinate);
        }

        public override string ToString()
        {
            return "[" + ID + " " + Name + " " + (Gender ? "Male" : "Female") + " " + Birth + " " + Age + " " + Address + " " + Salary + " " + Designation + " " + Dept + " " + Subordinate + "]";
        }
    }
}
