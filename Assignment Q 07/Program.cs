namespace Question07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Accept();
            p.Print();
            Console.WriteLine(p);

            Console.ReadLine();
        }
    }
}
