using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace Question06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Date d = new Date(29, 2, 2001);
            //Date d = new Date();
            //d.AcceptDate();

            Date d1 = new Date(25, 4, 2024);
            Date d2 = new Date(25, 4, 2001);
            d1.PrintDate();
            d2.PrintDate();
            //Console.WriteLine("Is Date Valid - "+d.isValid());
            Console.WriteLine("year diff " + (d2 - d1));
            //Console.WriteLine(d.ToString());

            Console.ReadLine();

        }//main-end
    }// program-class-end

    public class Date
    {
        // field
        private int day;
        private int month;
        private int year;

        // constructor
        public Date()
        {

        }

        public Date(int day, int month, int year)
        {
            this.day = day; 
            this.month = month;
            this.year = year;
        }

        // getter setter method
        public int Day
        {
            set { this.day = value; }
            get { return this.day; }
        }

        public int Month
        { 
            set { this.month = value; }
            get { return this.month; }
        }

        public int Year
        {
            set { this.year = value; }
            get { return this.year; }
        }

        public void AcceptDate()
        {
            Console.Write("Enter day - ");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month - ");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year - ");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        public void PrintDate()
        {
            Console.WriteLine("Date - " + Day + "/" + Month + "/" + Year);
        }

        // method to check is year leap or not
        private bool isLeap(int year)
        {
            if (year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    return (year % 400 == 0);
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool isValid()
        {
            if (month == 2)
            {
                if (isLeap(year))
                {
                    if (day >= 1 && day <= 29)
                        return true;
                    else
                        return false;
                }
                else
                {
                    if (day >= 1 && day <= 28)
                        return true;
                    else
                        return false;
                }
            }
            else if (month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (day >= 1 && day <= 31)
                            return true;
                        else
                            return false;
                        break;

                    case 2:
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (day >= 1 && day <= 30)
                            return true;
                        else
                            return false;
                        break;

                    default:
                        return false;
                }// end of switch
            }
            else
            {
                return false;
            }
            // end of else if
        }

        // Overriding ToString() method
        public override string ToString()
        {
            return "Date - " + Day + "/" + Month + "/" + Year;
        }

        // Overloading minus operator
        public static int operator -(Date d1, Date d2)
        {
            if (d1.year == d2.year)
                return 0;
            else if(d1.year < d2.year)
            {
                if (d1.month <= d2.month)
                    return d2.year - d1.year;
                else
                    return d2.year - d1.year - 1;
            }
            else
            {
                if (d2.month <= d1.month)
                    return d1.year - d2.year;
                else
                    return d1.year - d2.year - 1;
            }
        }
    }//Date-class-end
}
