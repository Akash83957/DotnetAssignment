using AssQuestion8;
using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace AssQuestion12
{
    internal class Program
    {
        int choice;
        public int menu() 
        {
            
            return choice;
        }
        static void Main(string[] args)
        {
            Company company = new Company();
            int choice;
            company.Accept();
            do
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1,Add Employee");
                Console.WriteLine("2.Remove Employee");
                Console.WriteLine("3,Search Employee by id ");
                Console.WriteLine("4.Display Employee");              
                Console.WriteLine("5.Display Company Details ");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thank You...");
                        break;
                    case 1:
                        {
                            Employee employee = new Employee();
                            employee.AcceptDetails();
                            company.AddEmployee(employee);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter ID of Employee to remove : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            if (company.RemoveEmployee(id))
                                Console.WriteLine("Employee removed Successfully.");
                            else
                            {
                                Console.WriteLine("Employee not found..");
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter ID of Employee to search : ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            LinkedListNode<Employee> e1 = company.FindEmployee(id);
                            if(e1 != null)
                            {
                                Console.WriteLine(e1.Value);
                            }
                            else
                            {
                                Console.WriteLine("Employee is not found");
                            }
                       }
                        break;
                    case 4:company.PrintEmployee();
                        break;
                    case 5:
                        company.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice....!!");
                        break;




                }
            } while (choice != 0) ;
        }
    }
}
