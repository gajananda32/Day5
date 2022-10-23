using System;
namespace TocheckGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int a = 5;
            int b = 10;
            int c = 15;
            //checking a is greater
            if (a > b)
            {
                //checking a greater 
                if (a > c)
                {
                    Console.WriteLine(a + " " + "is greatest");
                }
                else
                {
                    Console.WriteLine(c + " " + "is greatest");
                }
            }
            //checking b is greater
            else if (b > c)
            {
                Console.WriteLine(b + " " + "is greatest");
            }
            else
            {
                Console.WriteLine(c + " " + "is greatest");
            }
        }
    }
}
