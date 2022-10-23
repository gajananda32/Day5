using System;
namespace CheckLeapYear
{
    class program
    {
        static void Main(string[] args)
        {
            //taking four digit number from user
            Console.WriteLine("Enter Year: ");
            //converting string to integer
            int year = int.Parse(Console.ReadLine());
            //condistion for leap year
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " " + "is leap year");
            }
            else
            {
                Console.WriteLine(year + " " + "is not a leap year");
            }
        }
    }
}
