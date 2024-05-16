namespace Assignments1_Q2
{
    internal class Calculator
    {
        static void Main(string[] args)
       
        {
            
            Console.WriteLine("Calculator");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplaction");
            Console.WriteLine("4. division");
            Console.WriteLine("Enter the choice :");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
             choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Thank you");
                    break;

                case 1:
                    Console.WriteLine("Addition is " + (num1 + num2));
                    break;

                case 2:
                    Console.WriteLine("Subtraction is " + (num1 - num2));
                    break;

                case 3:
                    Console.WriteLine("Multiplaction is " + (num1 * num2));
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot be a value zero");
                        break;
                    }
                    else
                        Console.WriteLine("Division is " + (num1 / num2));
                    break;
                    default:Console.WriteLine("Wrong Choice");
                    break;
                                
                }
                while(choice != 0);


        }
    }
}
