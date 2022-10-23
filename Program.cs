using System;
namespace TofindQuotient
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int i, j, k, l;
            //taking input from user
            Console.WriteLine("Enter the first number");
            //converting string to integer
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            j = Convert.ToInt32(Console.ReadLine());
            //calculation
            k = i / j;
            l = i % j;
            Console.WriteLine("Quotient is: "+k);
            Console.WriteLine("Remainder is: "+l);

        }
    }
}
