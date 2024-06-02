using AssQuestion8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssQuestion12
{
    public class Company
    {
		private string  name;
		private string  address;
		private double salaryExpense;
        private LinkedList<Employee> emplist = new LinkedList<Employee>();

        public Company() 
		{
		    string name = string.Empty;
			string address = string.Empty;
		    double salaryExpense = 0.0;
		}
		public Company(string name , string address, double salaryExpense)
		{
			this.name = name;	
			this.address = address;
			this.salaryExpense = salaryExpense;
		}
		public double SalaryExpense
		{
			get { return salaryExpense; }
			set { salaryExpense = value; }
		}


		public string  Address
		{
			get { return address; }
			set { address = value; }
		}


		public string  Name
		{
			get { return name; }
			set { name = value; }
		}
		

		public LinkedList<Employee> Emplist
		{
			get { return emplist; }
			set { emplist = value; }
		}

		public void Accept()
		{
            Console.WriteLine("Enter Company Name : ");
			Name = Console.ReadLine();
            Console.WriteLine("Enter Company Address : ");
			Address = Console.ReadLine();
		}
		public void Display()
		{
            Console.WriteLine("Company Name : "+Name);
			Console.WriteLine("Company Address : "+Address);
            Console.WriteLine("Total number of Employee : "+emplist.Count);
            Console.WriteLine("Total Salary Expenses pf Company : "+CalculateSalaryExpense());
        }
		public double CalculateSalaryExpense()
		{
			SalaryExpense = 0;
            foreach (var employee in emplist)
            {
				this.SalaryExpense+= employee.Salary;
            }
            return SalaryExpense;
        }
		public void AddEmployee(Employee e)
		{
			Emplist.AddLast(e);
			
		}
		public bool RemoveEmployee(int id)
		{
			foreach (Employee emp in Emplist) 
			{
				if(emp.ID == id)
				{
					emplist.Remove(emp);
					return true;
				}

				
			}
            return false;
        }
		public LinkedListNode<Employee> FindEmployee(int id)
		{
			foreach(Employee emp in Emplist)
			{
				if (emp.ID == id)
				{
					return Emplist.Find(emp);
				}
				
			}return null;
		}
        public override string ToString()
        {
            return "Company Name : "+name+", Company Address : "+address+", Salary Expense : "+CalculateSalaryExpense();
        }
        public void PrintEmployee() 
		{
            Console.WriteLine("Employees : ");
			foreach (var emp in Emplist)
			{  if(Emplist.Count != 0) { 
				Console.WriteLine(emp);
                }
			else
				{
                    Console.WriteLine("Employee List is Empty.");
                }
            }
        }

	}
}
