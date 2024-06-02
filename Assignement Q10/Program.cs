//
namespace Question10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Supervisor sp = new Supervisor();
            sp.Accept();
            sp.Print();
            Console.WriteLine(sp);

            Console.ReadLine();
        }
    }
}
