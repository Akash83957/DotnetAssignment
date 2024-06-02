//
namespace Question09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Employee emp = new Manager();
            //emp.Accept();
            //Manager mp = (Manager)emp;
            //mp.Print();

            Manager m = new Manager();
            m.Accept();
            Employee emp = m;
            emp.Print();

            Console.ReadLine();
        }
    }
}
