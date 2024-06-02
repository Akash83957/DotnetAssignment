//
namespace Question08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Person p = new Person();
            //p.Accept();
            //p.Print();

            //Employee emp = new Employee();
            //emp.Accept();
            //emp.Print();
            //Console.WriteLine(emp);

            Employee employee = new Employee("Omkar", true, new Date(25, 4, 2001),
                "Pune",25000,"Manager",DepartmentType.Finance);

            employee.Print();
            Console.WriteLine(employee);


            Console.ReadLine();
        }
    }
}
